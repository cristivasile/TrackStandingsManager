using CompLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI.Forms
{
    public partial class VehicleManagerForm : TemplateFormResizable
    {
        //TODO - make edit and delete buttons less ugly
        /// <summary>
        /// selected sort type of form. 1 = By names, 2 = By avg position
        /// </summary>
        private int SortType = 1;
        /// <summary>
        /// Selected filter type of form. 0 = By nothing, 1 = By Category, 2 = By brand
        /// </summary>
        private int FilterType = 0;
        /// <summary>
        /// Small button size in VehicleFlowPanel.
        /// </summary>
        private readonly int SmallButtonSize = 32;
        /// <summary>
        /// Large button size in VehicleFlowPanel.
        /// </summary>
        private readonly int LargeButtonSize = 36;
        /// <summary>
        /// Column divide = 5 => 5 equal columns.
        /// </summary>
        private readonly int SmallColumnDivide = 30;
        /// <summary>
        /// Column divide = 5 => 5 equal columns.
        /// </summary>
        private readonly int LargeColumnDivide = 7;
        /// <summary>
        /// Used in form filtering
        /// </summary>
        private HashSet<string> FilterResult;
        public VehicleManagerForm()
        {
            InitializeComponent();
            InitializeBorder();
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(SortType, FilterType);
        }

        private void LoadVehicleHeaderPanel()
        {
            bool ShowPictures = this.ShowPicturesCheck.Checked;
            FlowLayoutPanel VehiclesHeader = this.VehicleFlowPanelHeader;
            Color TextColor = Color.White;
            Label PositionLabel = new();
            Label BrandLabel = new();
            Label ModelLabel = new();
            Label CategoryLabel = new();

            //clear header of old children
            VehiclesHeader.Controls.Clear();

            PositionLabel.Text = "Pos";
            PositionLabel.AddToPanel(
                VehiclesHeader,
                SmallColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleCenter
                );

            //only show this label if pictures will be displayed
            if (ShowPictures)
            {
                Label PictureLabel = new();
                PictureLabel.Width = this.VehicleFlowPanel.Height / 10;
                PictureLabel.Text = "Picture";

                PictureLabel.AddToPanel(
                VehiclesHeader,
                0,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft,
                false
                );
            }

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

        }

        private void LoadVehiclePanel(int SortType, int FilterType = 0)
        {
            List<VehicleModel> Vehicles = GlobalData.Vehicles;
            List<VehicleModel> FilteredVehicles;
            FlowLayoutPanel VehiclesPanel = this.VehicleFlowPanel;
            Image ErrorImage = Properties.Resources.ErrorImage;
            Padding NoPadding = new (0);
            bool ShowPictures = this.ShowPicturesCheck.Checked;
            int ButtonSize;
            int MiddlePadding = 0;
            int CurrentIndex = 0;

            if (ShowPictures)
                ButtonSize = LargeButtonSize;
            else
                ButtonSize = SmallButtonSize;

            VehiclesPanel.Controls.Clear();
            VehiclesPanel.AutoScroll = false;

            if (FilterType == 0)
            {
                this.FilteredByLabel.Hide();
                this.FilteredByValueLabel.Hide();
                this.FilteredByValueLabel.Text = "nothing";
            }
            else if(FilterType == 1)
            {
                this.FilteredByLabel.Show();
                this.FilteredByValueLabel.Show();
                this.FilteredByValueLabel.Text = "brand";

                FilteredVehicles = new();
                foreach (VehicleModel vehicle in Vehicles)
                    if (FilterResult.Contains(vehicle.Brand))
                        FilteredVehicles.Add(vehicle);

                Vehicles = FilteredVehicles;
            }
            else
            {
                this.FilteredByLabel.Show();
                this.FilteredByValueLabel.Show();
                this.FilteredByValueLabel.Text = "category";

                FilteredVehicles = new();
                foreach (VehicleModel vehicle in Vehicles)
                    if (FilterResult.Contains(vehicle.Category))
                        FilteredVehicles.Add(vehicle);

                Vehicles = FilteredVehicles;
            }
            //sort by name
            if(SortType == 1)
            {
                Vehicles = Vehicles.OrderBy(x => x.Brand).ThenBy(x => x.Model).ToList<VehicleModel>();
                this.SortedByValueLabel.Text = "name";
            }
            else
            {
                Vehicles = Vehicles.OrderBy(x => x.AveragePosition).ToList<VehicleModel>();
                this.SortedByValueLabel.Text = "avg position";
            }


            foreach (VehicleModel Vehicle in Vehicles)
            {
                Label PositionLabel = new();
                Label BrandLabel = new();
                Label ModelLabel = new();
                Label CategoryLabel = new();
                Label EmptyPaddingLabel = new();
                Button EditButton = new();
                Button DeleteButton = new();
                Color TextColor = Color.SteelBlue;
                FlowLayoutPanel NewVehiclePanel = new();
                VehiclesPanel.Controls.Add(NewVehiclePanel);

                CurrentIndex++;

                //If the panel is sorted by position, color first 3 rows differently.
                if (SortType == 2 && CurrentIndex <= 3)
                {
                    if (CurrentIndex == 1)
                        TextColor = Color.Gold;
                    else if (CurrentIndex == 2)
                        TextColor = Color.Silver;
                    else if (CurrentIndex == 3)
                        TextColor = Color.FromArgb(176, 141, 87);
                }

                //alternate background color for rows
                if (CurrentIndex % 2 == 0)
                    NewVehiclePanel.BackColor = Color.FromArgb(245, 254, 255);
                else
                    NewVehiclePanel.BackColor = Color.FromArgb(228, 246, 255);

                NewVehiclePanel.Margin = NoPadding;
                NewVehiclePanel.Width = VehiclesPanel.Width;

                //rows with pictures will be taller
                if (ShowPictures)
                {
                    NewVehiclePanel.Height = VehiclesPanel.Height / 10;

                    if (Vehicles.Count > 10)
                        NewVehiclePanel.Width -= Utilities.ScrollBarWidth;
                }
                else
                {
                    NewVehiclePanel.Height = VehiclesPanel.Height / 20;

                    if (Vehicles.Count > 20)
                        NewVehiclePanel.Width -= Utilities.ScrollBarWidth;
                }

                PositionLabel.Text = Convert.ToString(CurrentIndex);

                PositionLabel.AddToPanel(
                NewVehiclePanel,
                SmallColumnDivide,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleCenter
                );

                if (ShowPictures)
                {
                    PictureBox Picture = new();
                    Picture.Height = NewVehiclePanel.Height;
                    Picture.Width = Picture.Height;
                    Picture.SizeMode = PictureBoxSizeMode.CenterImage;
                    if (Vehicle.ImagePath != "")
                    {
                        try
                        {
                            Picture.Image = Utilities.GetCopyImage(Vehicle.ImagePath);
                                
                        }
                        catch {
                            Picture.Image = ErrorImage;
                        }
                    }
                    else
                    {
                        Picture.Image = ErrorImage;
                    }
                    Picture.ResizeToFit();
                    NewVehiclePanel.Controls.Add(Picture);
                }


                BrandLabel.Text = Vehicle.Brand;
                BrandLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );


                ModelLabel.Text = Vehicle.Model;
                ModelLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );

                CategoryLabel.Text = Vehicle.Category;
                CategoryLabel.AddToPanel(
                NewVehiclePanel,
                LargeColumnDivide,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );


                //compute how much space is needed in the middle of the LayoutPanel
                if (MiddlePadding == 0) {
                    MiddlePadding = NewVehiclePanel.Width;
                    MiddlePadding -= Utilities.ScrollBarWidth;
                    foreach (Control control in NewVehiclePanel.Controls)
                        MiddlePadding -= control.Width;

                    MiddlePadding -= 3 * ButtonSize;
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
                EditButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
                EditButton.Tag = Convert.ToString(Vehicle.Id);
                EditButton.Click += new EventHandler(EditButton_Click);
                EditButton.AddToPanel(NewVehiclePanel, ButtonSize);

                DeleteButton.BackgroundImage = Properties.Resources.trash;
                DeleteButton.FlatAppearance.MouseDownBackColor = Color.Red;
                DeleteButton.Tag = Convert.ToString(Vehicle.Id);
                DeleteButton.Click += new EventHandler(DeleteButton_Click);
                DeleteButton.AddToPanel(NewVehiclePanel, ButtonSize - 5);

            }

            VehiclesPanel.AutoScroll = true;
        }

        private void VehicleViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
            Program.MainMenuFormInstance.BringToFront();
        }

        private void ShowPicturesCheck_CheckChanged(object sender, EventArgs e)
        {
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(SortType, FilterType);
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowPicturesCheck.Checked = false;
            this.SortType = 1;
            this.FilterType = 0;
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(SortType, FilterType);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int VehicleId = Convert.ToInt32(((Button)sender).Tag);
            this.Enabled = false;
            Program.VehicleUpdateFormInstance = new(VehicleId, this);
            Program.VehicleUpdateFormInstance.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int VehicleId = Convert.ToInt32(((Button)sender).Tag);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle?\nThis action is permanent and will remove it from all competitions!", "Are you sure", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                bool vehicleDeleted;
                foreach (IDataConnection connection in GlobalConfig.Connections)
                {
                    vehicleDeleted = connection.RemoveVehicle(VehicleId);
                    if (!vehicleDeleted)
                        MessageBox.Show("This vehicle does not exist!", "Error");
                    else
                        LoadVehiclePanel(SortType, FilterType);
                }

            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Program.VehicleAddFormInstance = new(this);
            Program.VehicleAddFormInstance.Show();
        }

        public void ReloadForm()
        {
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(SortType, FilterType);
        }
        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortType = 1;
            ReloadForm();
        }

        private void AveragePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortType = 2;
            ReloadForm();
        }

        private void BrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Program.FilterFormInstance = new(0, this);
            Program.FilterFormInstance.Show();
            FilterResult = Program.FilterFormInstance.Result;
            FilterType = 1;
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Program.FilterFormInstance = new(1, this);
            Program.FilterFormInstance.Show();
            FilterResult = Program.FilterFormInstance.Result;
            FilterType = 2;
        }

        private void ClearFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterType = 0;
            ReloadForm();
        }

    }
}
