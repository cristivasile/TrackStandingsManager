using CompLibrary;
using CompLibrary.Storage_Management;
using CompUI.Forms.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CompUI.Forms.Competition_Branch
{
    public partial class EntryAddForm : TemplateFormNotResizable
    {
        private readonly CompetitionModel CurrentCompetition;
        private readonly Dictionary<string, int> VehicleIds = new();
        public EntryAddForm(int CompetitionId)
        {
            this.CurrentCompetition = CRUD.GetCompetitionById(CompetitionId);
            InitializeComponent();
            InitializeBorder();
            InitializeVehicles();
            InitializeControls();
        }
        public void InitializeControls()
        {
            CurrentCompetitionLabel.Text = CurrentCompetition.Name;

            if (CurrentCompetition.PlacementType == 0)
                ScoringLabel.Text = "Time";
            else
                ScoringLabel.Text = "Points";

            if (CurrentCompetition.TimingType == -1)
                TimeFormatLabel.Hide();
            else if (CurrentCompetition.TimingType == 0)
                TimeFormatLabel.Text = "SS.mmm";
            else if (CurrentCompetition.TimingType == 1)
                TimeFormatLabel.Text = "MM:SS.mmm";
            else
                TimeFormatLabel.Text = "HH:MM:SS.mmm";
        }

        public void InitializeVehicles()
        {
            foreach (VehicleModel vehicle in GlobalData.Vehicles)
                VehicleIds[vehicle.Brand + " " + vehicle.Model] = vehicle.Id;

            VehicleComboBox.DataSource = VehicleIds.Keys.OrderBy(x => x).ToList<String>();
        }

        private void EntryInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CompetitionManagerFormInstance.Enabled = true;
            Program.CompetitionManagerFormInstance.BringToFront();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                double score = 0;

                //if using point system
                if (CurrentCompetition.PlacementType == 1)
                    score = Double.Parse(ScoreTextBox.Text.Trim());
                //if using timing system
                else if (CurrentCompetition.PlacementType == 0) {

                    int RequiredDigits = 0;

                    //Time format SS.mmm
                    if (CurrentCompetition.TimingType == 0)
                        RequiredDigits = 5;
                    //Time format MM:SS.mmm
                    else if (CurrentCompetition.TimingType == 1)
                        RequiredDigits = 7;
                    //Time format HH:MM:SS.mmm
                    else if (CurrentCompetition.TimingType == 2)
                        RequiredDigits = 9;

                    string TimeString = ScoreTextBox.Text.FilterDigits().PadZeroes(RequiredDigits);
                    Time CompetitorTime = new();

                    //Time format SS.mmm
                    if (CurrentCompetition.TimingType == 0)
                    {
                        CompetitorTime.Seconds = Int32.Parse(TimeString.Substring(0, 2));
                        CompetitorTime.Milliseconds = Int32.Parse(TimeString.Substring(2, 3));
                    }
                    //Time format MM:SS.mmm
                    else if (CurrentCompetition.TimingType == 1)
                    {
                        CompetitorTime.Minutes = Int32.Parse(TimeString.Substring(0, 2));
                        CompetitorTime.Seconds = Int32.Parse(TimeString.Substring(2, 2));
                        CompetitorTime.Milliseconds = Int32.Parse(TimeString.Substring(4, 3));
                    }
                    //Time format HH:MM:SS.mmm
                    else if (CurrentCompetition.TimingType == 2)
                    {
                        CompetitorTime.Hours = Int32.Parse(TimeString.Substring(0, 2));
                        CompetitorTime.Minutes = Int32.Parse(TimeString.Substring(2, 2));
                        CompetitorTime.Seconds = Int32.Parse(TimeString.Substring(4, 2));
                        CompetitorTime.Milliseconds = Int32.Parse(TimeString.Substring(6, 3));
                    }

                    score = CompetitorTime.GetTimeInSeconds();
                }


                CompetitorModel NewCompetitor = new(
                    VehicleIds[VehicleComboBox.Text],
                    score,
                    AuthorTextBox.Text.Trim()
                );

                Utilities.GenerateSuccess("Success!", MessagePanel);
                CRUD.CreateCompetitor(CurrentCompetition.Id, NewCompetitor);

                AuthorTextBox.Text = "";
                ScoreTextBox.Text = "";
                Program.CompetitionManagerFormInstance.ReloadVehiclePanels();
            }
        }

        private bool CheckData()
        {
            int RequiredDigits = 0;

            bool Found = false;
            //search for vehicle name
            foreach (string VehicleName in VehicleIds.Keys)
                if (VehicleComboBox.Text.ToLower().Trim() == VehicleName.ToLower())
                    Found = true;

            if (!Found)
            {
                Utilities.GenerateError("Vehicle does not exist!", MessagePanel);
                return false;
            }
            // Scoring information check
            if (string.IsNullOrEmpty(ScoreTextBox.Text))
            {
                //Error message depends on whether the competition uses timings or points
                if(CurrentCompetition.PlacementType == 1)
                    Utilities.GenerateError("Points can not be empty!", MessagePanel);
                else if(CurrentCompetition.PlacementType == 0)
                    Utilities.GenerateError("Time can not be empty!", MessagePanel);

                return false;
            }

            string CheckNumberOfDigits = ScoreTextBox.Text.FilterDigits();

            //if using point system
            if (CurrentCompetition.PlacementType == 1)
            {
                //check if string is a double number
                try
                {
                    double score = double.Parse(CheckNumberOfDigits);
                }
                catch
                {
                    Utilities.GenerateError("Score can contain only digits!", MessagePanel);
                    return false;
                }
            }
            //if using timing system
            else if (CurrentCompetition.PlacementType == 0)
            {
                int Minutes = -1, Seconds = -1;
                if (CheckNumberOfDigits.Length == 0)
                {
                    Utilities.GenerateError("Time must contain at least one digit!", MessagePanel);
                    return false;
                }
                //Time format SS.mmm
                if (CurrentCompetition.TimingType == 0)
                    RequiredDigits = 5;
                //Time format MM:SS.mmm
                else if (CurrentCompetition.TimingType == 1)
                    RequiredDigits = 7;
                //Time format HH:MM:SS.mmm
                else if (CurrentCompetition.TimingType == 2)
                    RequiredDigits = 9;

                if (CheckNumberOfDigits.Length > RequiredDigits)
                {
                    Utilities.GenerateError("Too many digits in time!", MessagePanel);
                    return false;
                }

                // padzeroes Example: 01 23 47 to 01 23 47 000
                string CheckTimeFormat = CheckNumberOfDigits.PadZeroes(RequiredDigits);

                //Time format SS.mmm
                if (CurrentCompetition.TimingType == 0)
                {
                    Seconds = Int32.Parse(CheckTimeFormat.Substring(0, 2));
                }
                //Time format MM:SS.mmm
                else if (CurrentCompetition.TimingType == 1)
                {
                    Minutes = Int32.Parse(CheckTimeFormat.Substring(0, 2));
                    Seconds = Int32.Parse(CheckTimeFormat.Substring(2, 2));
                }
                //Time format HH:MM:SS.mmm
                else if (CurrentCompetition.TimingType == 2)
                {
                    Minutes = Int32.Parse(CheckTimeFormat.Substring(2, 2));
                    Seconds = Int32.Parse(CheckTimeFormat.Substring(4, 2));
                }

                if (Minutes > 59)
                {
                    Utilities.GenerateError("Can't have more than 59 minutes!", MessagePanel);
                    return false;
                }
                if (Seconds > 59)
                {
                    Utilities.GenerateError("Can't have more than 59 seconds!", MessagePanel);
                    return false;
                }

            }
            return true;
        }

        private void VehicleAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.VehicleAddFormInstance = new(this);
            Program.VehicleAddFormInstance.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach (String vehicleName in VehicleIds.Keys)
                if (VehicleComboBox.Text.ToLower().Trim() == vehicleName.ToLower())
                {
                    VehicleModel SelectedVehicle = CRUD.GetVehicleById(VehicleIds[vehicleName]);
                    LoadVehicle(SelectedVehicle);
                    VehicleComboBox.Text = vehicleName;
                    return;
                }
            //if at this point the function did not stop, vehicle was not found
            Utilities.GenerateError("Vehicle not found!", MessagePanel);

            //TODO - Add functionality for partial matches.
        }

        private void LoadVehicle(VehicleModel Vehicle)
        {
            if(Vehicle.ImagePath != "")
            {
                VehiclePicture.Show();
                VehiclePicture.Image = Utilities.GetCopyImage(Vehicle.ImagePath);
            }
            else
            {
                VehiclePicture.Hide();
            }
        }

        private void VehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleModel SelectedVehicle = CRUD.GetVehicleById(VehicleIds[VehicleComboBox.Text.Trim()]);
            LoadVehicle(SelectedVehicle);
        }

        private void VehicleComboBox_LostFocus(object sender, EventArgs e)
        {

            //event fires twice, I have no idea why ¯\_(ツ)_/¯
            MessagePanel.Controls.Clear();

            bool Found = false;
            string FoundVehicle = "";
            //search for vehicle name
            foreach (string VehicleName in VehicleIds.Keys)
                if (VehicleComboBox.Text.ToLower().Trim() == VehicleName.ToLower())
                {
                    Found = true;
                    FoundVehicle = VehicleName;
                    VehicleComboBox.Text = FoundVehicle;
                }

            if (!Found)
            {
                Utilities.GenerateError("Vehicle does not exist!", MessagePanel);
                this.ActiveControl = this.VehicleComboBox;
            }
            else
            {
                VehicleModel SelectedVehicle = CRUD.GetVehicleById(VehicleIds[FoundVehicle]);
                LoadVehicle(SelectedVehicle);
            }
            
        }

    }
}
