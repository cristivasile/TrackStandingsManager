using CompLibrary;
using CompLibrary.Storage_Management;
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
    public partial class CompetitionManagerForm : TemplateFormResizable
    {

        private Dictionary<string, int> CompetitionIds = new();
        public CompetitionManagerForm()
        {
            InitializeComponent();
            InitializeBorder();
            InitializeCompetitions();
            CompetitionSelectBox.DataSource = CompetitionIds.Keys.ToList();

        }

        public void ReloadCompetitions(int NewId = -1)
        {
            if(NewId != -1)
            {
                InitializeCompetitions();
                CompetitionSelectBox.DataSource = CompetitionIds.Keys.ToList();
                CompetitionSelectBox.SelectedIndex = CompetitionIds.Count - 1;
            }
            else
            {
                CompetitionSelectBox.DataSource = CompetitionIds.Keys.ToList();
            }
        }

        private void SortTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void StandingsViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
            Program.MainMenuFormInstance.BringToFront();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            Program.EntryInsertFormInstance = new(CompetitionIds[CompetitionSelectBox.Text]);
            Program.EntryInsertFormInstance.Show();
            this.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Program.CompetitionAddFormInstance = new();
            Program.CompetitionAddFormInstance.Show();
            this.Enabled = false;
        }

        private void ReloadForm()
        {
            //TODO - implement this
        }

        private void InitializeCompetitions()
        {
            CompetitionIds = new();
            foreach (CompetitionModel competition in GlobalData.Competitions)
            {
                CompetitionIds[competition.Name] = competition.Id;
            }
        }

        private void CompetitionSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompetitionModel CurrentCompetition = CRUD.GetCompetitionById(CompetitionIds[CompetitionSelectBox.Text]);
            this.DescriptionTextBox.Text = CurrentCompetition.Description;

            if (CurrentCompetition.PlacementType == 0)
                this.ScoreTypeOutputLabel.Text = "Timings";
            else
                this.ScoreTypeOutputLabel.Text = "Points";

            if (CurrentCompetition.OrderingType == 0)
                this.SortedTypeOutputLabel.Text = "Ascending";
            else
                this.SortedTypeOutputLabel.Text = "Descending";

            if (CurrentCompetition.ImagePath == "")
                this.CompetitionPicture.Hide();
            else
            {
                this.CompetitionPicture.Show();
                this.CompetitionPicture.Image = Utilities.GetCopyImage(CurrentCompetition.ImagePath);
                this.CompetitionPicture.ResizeToFit();
            }
            this.VehicleFlowPanel.Controls.Clear();
        }
    }
}
