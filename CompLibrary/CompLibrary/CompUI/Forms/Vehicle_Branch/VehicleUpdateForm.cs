﻿using CompLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI
{
    public partial class VehicleUpdateForm : Form
    {

        //TODO - Implement Vehicle selector and search function
        VehicleModel StoredVehicle;
        bool ImageChanged = false;
        public VehicleUpdateForm(int vehicleId)
        {
            foreach (IDataConnection connection in GlobalConfig.Connections) {
                StoredVehicle = connection.GetVehicleById(vehicleId); 
            }
            InitializeComponent();
            CategoryComboBox.DataSource = GlobalData.Categories;
            LoadVehicle(StoredVehicle);
        }

        private void LoadVehicle(VehicleModel vehicle = null)
        {
            ImageChanged = false;
            if (vehicle != null)
            {
                this.SelectedComboBox.Text = vehicle.Brand + " " + vehicle.Model;
                this.BrandTextBox.Text = vehicle.Brand;
                this.ModelTextBox.Text = vehicle.Model;
                this.CategoryComboBox.Text = vehicle.Category;
                if (vehicle.ImagePath != "")
                {
                    this.VehiclePicture.Image = Utilities.GetCopyImage(vehicle.ImagePath);
                    VehiclePicture.ResizeToFit();
                    this.ImageInfoLabel.Visible = false;
                }
            }
            else
            {
                this.SelectedComboBox.Text = "";
                this.BrandTextBox.Text = "";
                this.ModelTextBox.Text = "";
                this.CategoryComboBox.Text = "";
                this.VehiclePicture.Image = null;
                this.ImageInfoLabel.Visible = true;
            }
        }

        private bool VehicleChanged(VehicleModel vehicle) {
            if (vehicle.Category != StoredVehicle.Category
                || vehicle.Brand != StoredVehicle.Brand
                || vehicle.Model != StoredVehicle.Model
                || vehicle.Category != StoredVehicle.Category
                || ImageChanged)
                return true;
            return false;
        }

        private bool CheckData()
        {
            bool status = true;

            // Deals with previous errors
            MessagePanel.Controls.Clear();

            // Brand information check
            if (string.IsNullOrEmpty(BrandTextBox.Text))
            {
                Utilities.GenerateError("Brand can not be empty!", MessagePanel);
                status = false;
            }

            // Model information check
            if (string.IsNullOrEmpty(ModelTextBox.Text))
            {
                Utilities.GenerateError("Model can not be empty!", MessagePanel);
                status = false;
            }

            // Category information check
            if (string.IsNullOrEmpty(CategoryComboBox.Text))
            {
                Utilities.GenerateError("Category can not be empty!", MessagePanel);
                status = false;
            }

            //check if vehicle with this name already exists
            foreach (VehicleModel vehicle in GlobalData.Vehicles)
                if (vehicle.Brand.ToLower().Trim() + vehicle.Model.ToLower().Trim() ==
                    BrandTextBox.Text.ToLower().Trim() + ModelTextBox.Text.ToLower().Trim())
                {
                    Utilities.GenerateError("Vehicle already exists!", MessagePanel);
                    status = false;
                }

            return status;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Controls.Clear();
            VehicleModel UpdatedVehicle;
            if (StoredVehicle != null)
            {
                UpdatedVehicle = new VehicleModel(StoredVehicle);
                string filePath = StoredVehicle.ImagePath;
                if (ImageChanged)
                {
                    File.Delete(StoredVehicle.ImagePath);
                    filePath = GlobalConfig.ImageStorage.Save(VehiclePicture.Image);
                }

                UpdatedVehicle.Model = ModelTextBox.Text;
                UpdatedVehicle.Brand = BrandTextBox.Text;
                UpdatedVehicle.Category = CategoryComboBox.Text;
                UpdatedVehicle.ImagePath = filePath;

                if (VehicleChanged(UpdatedVehicle) && CheckData())
                {
                    foreach (IDataConnection connection in GlobalConfig.Connections)
                        connection.UpdateVehicle(UpdatedVehicle);
                    Utilities.GenerateSuccess("Vehicle successfully updated!", MessagePanel);
                    StoredVehicle = UpdatedVehicle;
                    Program.VehicleManagerFormInstance.ReloadForm();
                }

                else if (!VehicleChanged(UpdatedVehicle))
                    Utilities.GenerateError("Vehicle has not changed!", MessagePanel);
            }
            else
            {
                Utilities.GenerateError("No vehicle to update!", MessagePanel);
            }
        }

        private void VehiclePicture_Click(object sender, EventArgs e)
        {
            //if there's an image in clipboard
            if (Clipboard.ContainsImage())
            {
                VehiclePicture.Image = Clipboard.GetImage();

                //make the image fit the box
                VehiclePicture.ResizeToFit();

                //Removes info label
                ImageInfoLabel.Text = "";

                VehiclePicture.BackColor = Color.White;

                ImageChanged = true;
            }
            else
            {
                MessageBox.Show("No image in clipboard", "Error", MessageBoxButtons.OK);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.VehicleManagerFormInstance.Enabled = true;
            Program.VehicleManagerFormInstance.BringToFront();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DeleteVehicleButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Controls.Clear();
            if (StoredVehicle != null)
            {
                int VehicleId = StoredVehicle.Id;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle?\nThis action is permanent and will remove it from all competitions!", "Are you sure", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool vehicleDeleted;
                    foreach (IDataConnection connection in GlobalConfig.Connections)
                    {
                        vehicleDeleted = connection.RemoveVehicle(VehicleId);
                        if (!vehicleDeleted)
                            Utilities.GenerateError("Vehicle does not exist!", MessagePanel);
                        else
                        {
                            LoadVehicle();
                            StoredVehicle = null;
                            Utilities.GenerateSuccess("Vehicle deleted!", MessagePanel);
                            Program.VehicleManagerFormInstance.ReloadForm();
                        }
                    }
                }
            }
            else
            {
                Utilities.GenerateError("No vehicle to delete!", MessagePanel);
            }
        }

        //source https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        // ------ //

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void VehicleAddForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // ------ //

        private void UndoChangesButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Controls.Clear();
            if (StoredVehicle != null)
            {
                LoadVehicle(StoredVehicle);
                Utilities.GenerateSuccess("Changes successfuly undone!", MessagePanel);
            }
            else
                Utilities.GenerateError("No vehicle to reset!", MessagePanel);
        }

        private void VehiclePicture_MouseHover(object sender, EventArgs e)
        {
            VehiclePicture.BackColor = Color.Silver;
            ImageInfoLabel.BackColor = Color.Silver;
        }

        private void VehiclePicture_MouseLeave(object sender, EventArgs e)
        {
            VehiclePicture.BackColor = Color.White;
            ImageInfoLabel.BackColor = Color.White;
        }

    }
}
