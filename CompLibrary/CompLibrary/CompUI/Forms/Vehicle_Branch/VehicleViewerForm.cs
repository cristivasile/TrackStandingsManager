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
    public partial class VehicleViewerForm : Form
    {
        private int SortType = 1;
        private int FilterType = 0;
        public VehicleViewerForm()
        {
            InitializeComponent();
            this.VehicleFlowPanel.AutoScroll = true;
            LoadVehicleHeaderPanel();
            LoadVehiclePanel(SortType, FilterType);
        }

        private void LoadVehicleHeaderPanel()
        {
            bool ShowPictures = this.ShowPicturesCheck.Checked;
            FlowLayoutPanel VehiclesHeader = this.VehicleFlowPanelHeader;
            VehiclesHeader.Controls.Clear();
            Label PositionLabel = new();
            Label BrandLabel = new();
            Label ModelLabel = new();
            Label CategoryLabel = new();
            Color TextColor = Color.White;

            PositionLabel.Text = "Pos";
            PositionLabel.AddToPanel(
                VehiclesHeader,
                30,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleCenter
                );

            if (ShowPictures)
            {
                Label PictureLabel = new();
                PictureLabel.Width = this.VehicleFlowPanel.Height / 10;
                PictureLabel.Text = "Picture";

                PictureLabel.AddToPanel(
                VehiclesHeader,
                10,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft,
                false
                );
            }

            BrandLabel.Text = "Brand";
            BrandLabel.AddToPanel(
                VehiclesHeader,
                7,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );

            ModelLabel.Text = "Model";
            ModelLabel.AddToPanel(
                VehiclesHeader,
                7,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );

            CategoryLabel.Text = "Category";
            CategoryLabel.AddToPanel(
                VehiclesHeader,
                7,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );

        }

        private void LoadVehiclePanel(int SortType, int FilterType = 0)
        {
            bool ShowPictures = this.ShowPicturesCheck.Checked;
            List<VehicleModel> Vehicles = GlobalData.Vehicles;
            FlowLayoutPanel VehiclesPanel = this.VehicleFlowPanel;
            VehiclesPanel.Controls.Clear();
            Image ErrorImage = Properties.Resources.ErrorImage;

            //TODO - add filter options
            if (FilterType == 0)
                this.FilteredByValueLabel.Text = "nothing";

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


            int ButtonSize = 32;

            if (ShowPictures)
                ButtonSize = 44;

            int MiddlePadding = 0;

            int CurrentIndex = 0;
            foreach (VehicleModel Vehicle in Vehicles)
            {
                CurrentIndex++;
                FlowLayoutPanel NewVehiclePanel = new();

                if (CurrentIndex % 2 == 0)
                    NewVehiclePanel.BackColor = Color.FromArgb(245, 254, 255);
                else
                    NewVehiclePanel.BackColor = Color.FromArgb(228, 246, 255);

                NewVehiclePanel.Margin = new Padding(0);
                VehiclesPanel.Controls.Add(NewVehiclePanel);

                NewVehiclePanel.Width = VehiclesPanel.Width;

                if (ShowPictures)
                {
                    NewVehiclePanel.Height = VehiclesPanel.Height / 10;

                    if (Vehicles.Count >= 10)
                        NewVehiclePanel.Width -= Utilities.ScrollBarWidth;
                }
                else
                {
                    NewVehiclePanel.Height = VehiclesPanel.Height / 20;

                    if (Vehicles.Count >= 20)
                        NewVehiclePanel.Width -= Utilities.ScrollBarWidth;
                }

                Label PositionLabel = new();
                Label BrandLabel = new();
                Label ModelLabel = new();
                Label CategoryLabel = new();
                Label EmptyPaddingLabel = new();
                Button EditButton = new();
                Button DeleteButton = new();

                PositionLabel.Text = Convert.ToString(CurrentIndex);
                Color TextColor = Utilities.FishBlue;

                if (SortType == 2)
                {
                    if (CurrentIndex == 1)
                        TextColor = Color.Gold;
                    else if (CurrentIndex == 2)
                        TextColor = Color.Silver;
                    else if (CurrentIndex == 3)
                        TextColor = Color.FromArgb(176, 141, 87);
                }

                PositionLabel.AddToPanel(
                NewVehiclePanel,
                30,
                Utilities.LargeTextBold,
                TextColor,
                ContentAlignment.MiddleLeft
                );

                if (ShowPictures)
                {
                    PictureBox Picture = new();
                    Picture.Height = NewVehiclePanel.Height;
                    Picture.Width = Picture.Height;
                    Picture.SizeMode = PictureBoxSizeMode.CenterImage;
                    if (Vehicle.ImagePath != "")
                    {
                        Picture.Image = Image.FromFile(Vehicle.ImagePath);
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
                7,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );


                ModelLabel.Text = Vehicle.Model;
                ModelLabel.AddToPanel(
                NewVehiclePanel,
                7,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );

                CategoryLabel.Text = Vehicle.Category;
                CategoryLabel.AddToPanel(
                NewVehiclePanel,
                7,
                Utilities.LargeText,
                TextColor,
                ContentAlignment.MiddleLeft
                );


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

                EditButton.BackgroundImage = Properties.Resources.edit1;
                EditButton.AddToPanel(NewVehiclePanel, ButtonSize);
                EditButton.FlatAppearance.MouseDownBackColor = Color.SteelBlue;

                DeleteButton.BackgroundImage = Properties.Resources.tresh;
                DeleteButton.AddToPanel(NewVehiclePanel, ButtonSize - 5);
                DeleteButton.FlatAppearance.MouseDownBackColor = Color.Red;

                //TODO - vehicle edit and buttons currently to nothing, add functionality
            }
        }

        private void FilterByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VehicleViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.VehicleManagerFormInstance.Show();
        }

        //source https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        // ------ //

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void VehicleViewerForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // ------ //

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
