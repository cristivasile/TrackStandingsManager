using CompLibrary;
using CompLibrary.Storage_Management;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CompUI.Forms.Competition_Branch
{
    public partial class CompetitionManagerForm : Templates.TemplateFormNotResizable
    {

        /// <summary>
        /// Selected filter type of form. 0 = By nothing, 1 = By Category, 2 = By brand
        /// </summary>
        private int FilterType = 0;
        /// <summary>
        /// Small button size in VehicleFlowPanel.
        /// </summary>
        private readonly int SmallButtonSize = 32;
        /// <summary>
        /// Column divide = 5 => 5 equal columns.
        /// </summary>
        private readonly int SmallColumnDivide = 30;
        private readonly int LargeColumnDivide = 7;
        private readonly int SmallRowHeight = 35;
        /// <summary>
        /// Used in form filtering
        /// </summary>
        private HashSet<string> FilterResult;

        private Dictionary<string, int> CompetitionIds = new();
        public CompetitionModel CurrentCompetition;
        public CompetitionManagerForm()
        {
            InitializeComponent();
            InitializeBorder();
            InitializeCompetitions();
            InitializeControls();
            ReloadVehiclePanels();
        }

        public void InitializeControls()
        {
            if (CompetitionIds.Keys.Count == 0)
                AddEntryButton.Enabled = false;
        }

        public void ReloadCompetitions(bool newCompetitionAdded = false)
        {
            if(newCompetitionAdded)
            {
                InitializeCompetitions();
                CompetitionSelectBox.SelectedIndex = CompetitionIds.Count - 1;
            }
            else
            {
                CompetitionSelectBox.DataSource = CompetitionIds.Keys.ToList();
            }
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

        private void InitializeCompetitions()
        {
            CurrentCompetition = null;
            CompetitionIds = new();
            foreach (CompetitionModel competition in GlobalData.Competitions)
            {
                CompetitionIds[competition.Name] = competition.Id;
            }

            CompetitionSelectBox.DataSource = CompetitionIds.Keys.OrderBy(x => x).ToList();

            if (CompetitionIds.Keys.ToList().Count == 0)
            {
                CompetitionSelectBox.SelectedIndex = -1;
            }

        }

        private void CompetitionSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCompetition = CRUD.GetCompetitionById(CompetitionIds[CompetitionSelectBox.Text]);
            this.DescriptionTextBox.Text = CurrentCompetition.Description;
            this.AddEntryButton.Enabled = true;

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
            }

            this.VehicleFlowPanel.Controls.Clear();
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(0);

        }

        private void CompetitionSelectBox_Leave(object sender, EventArgs e)
        {
            bool found = false;
            foreach (string competitionName in CompetitionIds.Keys)
                if (CompetitionSelectBox.Text.Trim().ToLower() == competitionName.ToLower())
                {
                    CompetitionSelectBox.Text = competitionName;
                    CompetitionSelectBox.SelectedItem = competitionName;
                    found = true;
                }

            if (!found)
            {
                CompetitionSelectBox.Focus();
                AddEntryButton.Enabled = false;
            }
        }


        private void LoadVehicleHeaderPanel()
        {
            FlowLayoutPanel VehiclesHeader = this.VehicleFlowPanelHeader;
            Color TextColor = Color.White;
            Label PositionLabel = new();
            Label ScoreLabel = new();
            Label BrandLabel = new();
            Label ModelLabel = new();
            Label CategoryLabel = new();
            Label AuthorLabel = new();

            VehiclesHeader.Controls.Clear();

            PositionLabel.Text = "Pos";
            PositionLabel.AddToPanel(
                VehiclesHeader,
                SmallColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleCenter
                );

            ContentAlignment PointsAlignment = ContentAlignment.MiddleLeft;

            if (CurrentCompetition != null)
            {
                if (CurrentCompetition.PlacementType == 1)
                {
                    ScoreLabel.Text = "Points";
                    PointsAlignment = ContentAlignment.MiddleCenter;
                }
                else
                    ScoreLabel.Text = "Time";
            }
            else
            {
                ScoreLabel.Text = "Score";
            }
            ScoreLabel.AddToPanel(
                VehiclesHeader,
                LargeColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                PointsAlignment
                );

            BrandLabel.Text = "Brand";
            BrandLabel.AddToPanel(
                VehiclesHeader,
                LargeColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );

            ModelLabel.Text = "Model";
            ModelLabel.AddToPanel(
                VehiclesHeader,
                LargeColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );

            CategoryLabel.Text = "Category";
            CategoryLabel.AddToPanel(
                VehiclesHeader,
                LargeColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );


            AuthorLabel.Text = "Author";
            AuthorLabel.AddToPanel(
                VehiclesHeader,
                LargeColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );
        }

        private void LoadVehiclePanel(int FilterType = 0)
        {
            List<CompetitorModel> Competitors = new();
            if (CurrentCompetition != null)
            {
                Competitors = CurrentCompetition.Competitors;
            }
            List<CompetitorModel> FilteredCompetitors;
            FlowLayoutPanel VehiclesPanel = this.VehicleFlowPanel;
            Image ErrorImage = Properties.Resources.ErrorImage;
            Padding NoPadding = new(0);
            int ButtonSize;
            int MiddlePadding = 0;
            int CurrentIndex = 0;

            //used for calculating positions
            int CurrentPosition = 0;
            double LastPosition = -1;
            int toIncrement = 1;

            //example: vehicle with id 13 is on vehicles[10], so 13:10
            Dictionary<int, int> VehicleIdsToIndexes = FunctionLibrary.MapVehicleIdsToIndexes();

            ButtonSize = SmallButtonSize;

            VehiclesPanel.Controls.Clear();
            VehiclesPanel.AutoScroll = false;

            if (FilterType == 0)
            {
                this.FilteredByLabel.Hide();
                this.FilteredByValueLabel.Hide();
                this.FilteredByValueLabel.Text = "nothing";
            }
            else if (FilterType == 1)
            {
                this.FilteredByLabel.Show();
                this.FilteredByValueLabel.Show();
                this.FilteredByValueLabel.Text = "brand";

                FilteredCompetitors = new();
                foreach (CompetitorModel competitor in CurrentCompetition.Competitors)
                    if (FilterResult.Contains(GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]].Brand))
                        FilteredCompetitors.Add(competitor);

                Competitors = FilteredCompetitors;
            }
            else
            {
                this.FilteredByLabel.Show();
                this.FilteredByValueLabel.Show();
                this.FilteredByValueLabel.Text = "category";

                FilteredCompetitors = new();
                foreach (CompetitorModel competitor in CurrentCompetition.Competitors)
                    if (FilterResult.Contains(GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]].Category))
                        FilteredCompetitors.Add(competitor);

                Competitors = FilteredCompetitors;
            }
            
            foreach (CompetitorModel competitor in Competitors)
            {
                Label PositionLabel = new();
                Label ScoreLabel = new();
                Label BrandLabel = new();
                Label ModelLabel = new();
                Label CategoryLabel = new();
                Label AuthorLabel = new();
                Label EmptyPaddingLabel = new();
                Button EditButton = new();
                Button DeleteButton = new();
                Color TextColor = Color.SteelBlue;
                FlowLayoutPanel NewVehiclePanel = new();
                VehiclesPanel.Controls.Add(NewVehiclePanel);
                VehicleModel CompetitorVehicle = GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]];

                CurrentIndex++;

                if (competitor.Position != LastPosition)
                {
                    CurrentPosition += toIncrement;
                    LastPosition = competitor.Position;
                    toIncrement = 1;
                }
                else
                {
                    toIncrement++;
                }

                //Color first 3 rows differently.
                if (CurrentPosition <= 3)
                {
                    if (CurrentPosition == 1)
                        TextColor = Color.Gold;
                    else if (CurrentPosition == 2)
                        TextColor = Color.Silver;
                    else if (CurrentPosition == 3)
                        TextColor = Color.FromArgb(176, 141, 87);
                }

                //alternate background color for rows
                if (CurrentIndex % 2 == 0)
                    NewVehiclePanel.BackColor = Color.FromArgb(245, 254, 255);
                else
                    NewVehiclePanel.BackColor = Color.FromArgb(228, 246, 255);

                NewVehiclePanel.Margin = NoPadding;
                NewVehiclePanel.Width = VehiclesPanel.Width;
                NewVehiclePanel.Height = SmallRowHeight;

                //if scrollbar is needed resize panel
                if (Competitors.Count > VehicleFlowPanel.Height / NewVehiclePanel.Height)
                    NewVehiclePanel.Width -= Utilities.ScrollBarWidth;


                PositionLabel.Text = Convert.ToString(CurrentPosition);
                PositionLabel.AddToPanel(
                NewVehiclePanel,
                SmallColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleCenter
                );

                //points will be centered, timings will be aligned on the left
                ContentAlignment ScoreAlignment;

                //if using score
                if (CurrentCompetition.PlacementType == 1)
                {
                    ScoreLabel.Text = Convert.ToString(competitor.Score);
                    ScoreAlignment = ContentAlignment.MiddleCenter;
                }
                //else get time string
                else
                {
                    ScoreLabel.Text = FunctionLibrary.GetTimeString(competitor.Score, CurrentCompetition.TimingType);
                    ScoreAlignment = ContentAlignment.MiddleLeft;
                }
                ScoreLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ScoreAlignment
                );

                BrandLabel.Text = CompetitorVehicle.Brand;
                BrandLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );


                ModelLabel.Text = CompetitorVehicle.Model;
                ModelLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );

                CategoryLabel.Text = CompetitorVehicle.Category;
                CategoryLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );

                if (competitor.Author == "")
                    AuthorLabel.Text = "-";
                else
                    AuthorLabel.Text = competitor.Author;

                AuthorLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );
                //compute how much space is needed in the middle of the LayoutPanel
                if (MiddlePadding == 0)
                {
                    MiddlePadding = NewVehiclePanel.Width;
                    MiddlePadding -= Utilities.ScrollBarWidth;
                    foreach (Control control in NewVehiclePanel.Controls)
                        MiddlePadding -= control.Width;

                    MiddlePadding -= Convert.ToInt32(3.5 * ButtonSize);
                }

                EmptyPaddingLabel.Width = MiddlePadding;
                EmptyPaddingLabel.AddToPanel(
                NewVehiclePanel,
                0,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft,
                false
                );

                EditButton.BackgroundImage = Properties.Resources.edit;
                EditButton.FlatAppearance.MouseDownBackColor = Color.LightYellow;
                EditButton.Tag = Convert.ToString(competitor.Id);
                EditButton.Click += new EventHandler(EditButton_Click);
                EditButton.AddToPanel(NewVehiclePanel, ButtonSize);

                DeleteButton.BackgroundImage = Properties.Resources.trash;
                DeleteButton.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
                DeleteButton.Tag = Convert.ToString(competitor.Id);
                DeleteButton.Click += new EventHandler(DeleteButton_Click);
                DeleteButton.AddToPanel(NewVehiclePanel, ButtonSize - 5);

            }

            VehiclesPanel.AutoScroll = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //competitor id is stored in button tag
            int CompetitorId = Convert.ToInt32(((Button)sender).Tag);
            this.Enabled = false;

            Program.EntryUpdateFormInstance = new(CurrentCompetition.Id, CompetitorId);
            Program.EntryUpdateFormInstance.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //competitor id is stored in button tag
            int CompetitorId = Convert.ToInt32(((Button)sender).Tag);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry? The action is permanent!", "Please confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                CRUD.DeleteCompetitor(CurrentCompetition.Id, CompetitorId);
                ReloadVehiclePanels();
            }
        }

        private void BrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if competitions exist
            if (CurrentCompetition != null)
            {
                this.Enabled = false;
                Program.FilterFormInstance = new(0, this);
                Program.FilterFormInstance.Show();
                FilterResult = Program.FilterFormInstance.Result;
                FilterType = 1;
            }
            else
            {
                MessageBox.Show("No competition to filter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if competitions exist
            if (CurrentCompetition != null)
            {
                this.Enabled = false;
                Program.FilterFormInstance = new(1, this);
                Program.FilterFormInstance.Show();
                FilterResult = Program.FilterFormInstance.Result;
                FilterType = 2;
            }
            else
            {
                MessageBox.Show("No competition to filter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterType = 0;
            ReloadVehiclePanels();
        }

        public void ReloadVehiclePanels()
        {
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(FilterType);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if competitions exist
            if (CurrentCompetition != null)
            {
                CRUD.DeleteCompetition(CurrentCompetition.Id);
                InitializeCompetitions();

                if(CompetitionIds.Count == 0)
                {
                    CurrentCompetition = null;
                    this.CompetitionSelectBox.Text = "";
                    this.SortedTypeOutputLabel.Text = "<null>";
                    this.ScoreTypeOutputLabel.Text = "<null>";
                    this.CompetitionPicture.Hide();
                }

                ReloadVehiclePanels();
            }
            else
            {
                MessageBox.Show("No competition to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterType = 0;
            //check if competitions exist
            if (CurrentCompetition != null)
            {
                CompetitionSelectBox.SelectedIndex = 0;
            }
            else
            {
                CompetitionSelectBox.SelectedIndex = -1;
            }
            ReloadVehiclePanels();
        }

    }
}
