using CompLibrary;
using CompLibrary.Storage_Management;
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
    public partial class CompetitionAddForm : TemplateFormNotResizable
    {
        private Image LastImageInserted;
        public CompetitionAddForm()
        {
            InitializeComponent();
            InitializeBorder();
            this.TimingsTypeBox.DataSource = GlobalConfig.DefaultTimings;
            this.TimingsTypeBox.SelectedItem = null;
            this.TimingsTypeBox.SelectedText = "Select timing format";
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NewCompetitionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.CompetitionManagerFormInstance.Enabled = true;
            Program.CompetitionManagerFormInstance.BringToFront();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompetitionPicture_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, CompetitionPicture.ClientRectangle,
                Color.FromArgb(200, 246, 255), 3, ButtonBorderStyle.Solid,  //left
                Color.FromArgb(200, 246, 255), 3, ButtonBorderStyle.Solid,  //top
                Color.FromArgb(228, 246, 255), 3, ButtonBorderStyle.Solid,  //right
                Color.FromArgb(228, 246, 255), 3, ButtonBorderStyle.Solid); //bottom
        }

        private void CompetitionPicture_Click(object sender, EventArgs e)
        {
            //if there's an image in clipboard
            if (Clipboard.ContainsImage())
            {
                CompetitionPicture.Image = Clipboard.GetImage();
                LastImageInserted = Clipboard.GetImage();

                //make the image fit the box
                CompetitionPicture.ResizeToFit();

                //Removes info label
                ImageInfoLabel.Text = "";

                CompetitionPicture.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("No image in clipboard", "Error", MessageBoxButtons.OK);
            }
        }

        private void CompetitionPicture_MouseHover(object sender, EventArgs e)
        {
            CompetitionPicture.BackColor = Color.Silver;
            ImageInfoLabel.BackColor = Color.Silver;
        }

        private void CompetitionPicture_MouseLeave(object sender, EventArgs e)
        {
            CompetitionPicture.BackColor = Color.White;
            ImageInfoLabel.BackColor = Color.White;
        }

        private void TimingsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TimingsButton.Checked)
                TimingsTypeBox.Enabled = true;
            else
                TimingsTypeBox.Enabled = false;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                int PlacementType, OrderingType, TimingType, NewId = -1;
                if (PointsButton.Checked) {
                    PlacementType = 1;
                    TimingType = -1;
                }
                else { 
                    PlacementType = 0;
                    TimingType = TimingsTypeBox.SelectedIndex;    
                }

                if (DescendingButton.Checked)
                    OrderingType = 1;
                else OrderingType = 0;

                string ImagePath = "";
                if (CompetitionPicture.Image != null)
                {
                    ImagePath = GlobalConfig.ImageStorage.Save(LastImageInserted);
                }


                //creates a new vehicle with the data provided
                CompetitionModel NewCompetition = new(
                    NameTextBox.Text.Trim(),
                    DescriptionTextBox.Text.Trim(),
                    ImagePath,
                    PlacementType,
                    OrderingType,
                    TimingType
                    );



                NewId = CRUD.CreateCompetition(NewCompetition);

                //alerts the user that the insert is done
                Utilities.GenerateSuccess("Insert successful!", MessagePanel);

                //clears all fields
                NameTextBox.Text = "";
                DescriptionTextBox.Text = "";

                //resets image info label
                ImageInfoLabel.Text = "Click to paste \nimage from clipboard";

                //resets image frame
                CompetitionPicture.Image = null;

                Program.CompetitionManagerFormInstance.ReloadCompetitions(NewId);
                //TODO - Reload competition viewer with current competition
            }
        }

        /// <summary>
        /// Checks whether the data in the form is correct or not
        /// </summary>
        /// <returns>True if data is valid or false otherwise</returns>
        private bool CheckData()
        {
            bool status = true;

            // Name information check
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                Utilities.GenerateError("Name can not be empty!", MessagePanel);
                status = false;
            }

            // Timings information check
            if (TimingsButton.Checked && TimingsTypeBox.SelectedItem == null)
            {
                Utilities.GenerateError("Please choose a timing format!", MessagePanel);
                status = false;
            }

            //check if competition with this name already exists
            foreach (CompetitionModel competition in GlobalData.Competitions)
                if (competition.Name.ToLower().Trim() == NameTextBox.Text.ToLower().Trim())
                {
                    Utilities.GenerateError("Competition already exists!", MessagePanel);
                    status = false;
                }

            return status;
        }

    }
}
