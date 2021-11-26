using CompLibrary;
using CompUI.Forms.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CompUI.Forms
{
    public partial class RandomChoiceForm : TemplateFormNotResizable
    {

        private CompetitionModel RandomCompetition;
        public RandomChoiceForm()
        {
            InitializeComponent();
            InitializeBorder();

            CompetitionNameLabel.Hide();
            CompetitionDescriptionLabel.Hide();
            CompetitionDescriptionLabel.MaximumSize = new Size(DescriptionPanel.Width, DescriptionPanel.Height);

            VehicleNameLabel.Hide();
        }

        private void RandomChoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
        }

        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, CompetitionPicture.ClientRectangle,
                Color.FromArgb(200, 246, 255), 2, ButtonBorderStyle.Solid,  //left
                Color.FromArgb(200, 246, 255), 2, ButtonBorderStyle.Solid,  //top
                Color.FromArgb(200, 246, 255), 2, ButtonBorderStyle.Solid,  //right
                Color.FromArgb(200, 246, 255), 2, ButtonBorderStyle.Solid); //bottom
        }

        private void RandomCompetitionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GlobalData.Competitions.Count != 0)
            {
                if (RandomCompetitionCheckBox.Checked)
                {
                    RandomVehicleCheckBox.Enabled = true;
                    LoadCompetition();
                }
                else
                {
                    RandomVehicleCheckBox.Checked = false;
                    NotCompetitorCheckBox.Checked = false;
                    RandomVehicleCheckBox.Enabled = false;
                    NotCompetitorCheckBox.Enabled = false;
                    UnloadCompetition();
                    UnloadVehicle();
                }
            }
            else
            {
                CompetitionNameLabel.Text = "No competitions available!";
                CompetitionNameLabel.Show();
            }
        }

        private void RandomVehicleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomVehicleCheckBox.Checked)
            {
                NotCompetitorCheckBox.Enabled = true;
                LoadVehicle();
            }
            else
            {
                NotCompetitorCheckBox.Checked = false;
                NotCompetitorCheckBox.Enabled = false;
                UnloadVehicle();
            }
        }

        private void NotCompetitor_CheckStateChanged(object sender, EventArgs e)
        {
            UnloadVehicle();
            LoadVehicle();
        }

        void LoadCompetition()
        {
            System.Random RandomNumber = new();
            int index = RandomNumber.Next(0, GlobalData.Competitions.Count);
            RandomCompetition = GlobalData.Competitions[index];

            if (RandomCompetition.ImagePath != "")
                CompetitionPicture.Image = Utilities.GetCopyImage(RandomCompetition.ImagePath);
            else
                CompetitionPicture.Image = Properties.Resources.ErrorImage;

            CompetitionPicture.ResizeToFit();

            CompetitionNameLabel.Show();
            CompetitionNameLabel.Text = RandomCompetition.Name;

            if (RandomCompetition.Description.Length != 0)
            {
                CompetitionDescriptionLabel.Show();
                CompetitionDescriptionLabel.Text = RandomCompetition.Description;
            }

        }
        void UnloadCompetition()
        {
            CompetitionPicture.Image = null;
            CompetitionNameLabel.Hide();
            CompetitionDescriptionLabel.Hide();
        }

        void LoadVehicle()
        {
            HashSet<VehicleModel> VehicleList;

            VehicleList = GlobalData.Vehicles.ToHashSet();

            //remove vehicles that have already competed
            if (NotCompetitorCheckBox.Checked == true)
            {
                Dictionary<int, int> VehicleIdsToIndexes = FunctionLibrary.MapVehicleIdsToIndexes();

                //remove already existing competitors from possible vehicle list
                foreach (CompetitorModel competitor in RandomCompetition.Competitors)
                    VehicleList.Remove(GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]]);
            }

            //get random vehicle from list
            System.Random RandomNumber = new();
            int Index = RandomNumber.Next(0, VehicleList.Count);
            int Counter = 0;


            //iterate through hashset to get index-th vehicle
            VehicleModel RandomVehicle = new();
            foreach(VehicleModel vehicle in VehicleList)
            {
                if (Counter != Index)
                    Counter++;
                else
                {
                    RandomVehicle = vehicle;
                    break;
                }
            }

            if (RandomVehicle.ImagePath != "")
                VehiclePicture.Image = Utilities.GetCopyImage(RandomVehicle.ImagePath);
            else
                VehiclePicture.Image = Properties.Resources.ErrorImage;

            VehiclePicture.ResizeToFit();

            VehicleNameLabel.Show();
            VehicleNameLabel.Text = RandomVehicle.Brand + " " + RandomVehicle.Model;

        }
        void UnloadVehicle()
        {
            VehicleNameLabel.Hide();
            VehiclePicture.Image = null;
        }

    }
}
