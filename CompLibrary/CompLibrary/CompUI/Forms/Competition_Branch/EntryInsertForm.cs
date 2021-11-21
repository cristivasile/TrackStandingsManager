using CompLibrary;
using CompUI.Forms.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI.Forms.Competition_Branch
{
    public partial class EntryInsertForm : TemplateFormNotResizable
    {
        private CompetitionModel CurrentCompetition;
        private Dictionary<string, int> VehicleIds = new();
        public EntryInsertForm(int CompetitionId)
        {
            this.CurrentCompetition = FunctionLibrary.GetCompetitionById(CompetitionId);
            InitializeComponent();
            InitializeBorder();
            InitializeVehicles();
            VehicleComboBox.DataSource = VehicleIds.Keys.ToList<String>();
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

        private void InitializeVehicles()
        {
            foreach (VehicleModel vehicle in GlobalData.Vehicles)
                VehicleIds[vehicle.Brand + " " + vehicle.Model] = vehicle.Id;

        }

        private void BrandTextBox_TextChanged(object sender, EventArgs e)
        {

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
                Utilities.GenerateSuccess("Success!", MessagePanel);
                //TODO - actually add the competitor to the competition;
            }
        }

        private bool CheckData()
        {
            int RequiredDigits = 0;

            // Scoring information check
            if (string.IsNullOrEmpty(ScoreTextBox.Text))
            {
                //Error message depends on whether the competition uses timings or points
                if(CurrentCompetition.PlacementType == 0)
                    Utilities.GenerateError("Points can not be empty!", MessagePanel);
                else if(CurrentCompetition.PlacementType == 1)
                    Utilities.GenerateError("Time can not be empty!", MessagePanel);

                return false;
            }

            string CheckNumberOfDigits = ScoreTextBox.Text.FilterDigits();

            //if using point system
            if (CurrentCompetition.PlacementType == 1)
            {
                //check if string contains only digits
                if (CheckNumberOfDigits.Length < ScoreTextBox.Text.Trim().Length)
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
    }
}
