using CompLibrary;
using CompLibrary.Storage_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CompUI
{
    public partial class VehicleUpdateForm : Forms.Templates.TemplateFormNotResizable
    {
        private VehicleModel StoredVehicle;
        private bool ImageChanged = false;
        private readonly Dictionary<string, int> VehicleIds = new();
        private readonly new Form ParentForm;

        public VehicleUpdateForm(int vehicleId, Form sender)
        {
            StoredVehicle = GetVehicleById(vehicleId);
            ParentForm = sender;
            InitializeComponent();
            InitializeBorder();
            InitializeVehicleIds();
            CategoryComboBox.DataSource = GlobalData.Categories;
            VehicleComboBox.DataSource = VehicleIds.Keys.OrderBy(x => x).ToList<String>();
            LoadVehicle(StoredVehicle);
        }

        private void InitializeVehicleIds()
        {
            foreach (VehicleModel vehicle in GlobalData.Vehicles)
            {
                VehicleIds[vehicle.Brand + " " + vehicle.Model] = vehicle.Id;
            }
        }

        private void LoadVehicle(VehicleModel vehicle = null)
        {
            ImageChanged = false;
            if (vehicle != null)
            {
                this.VehicleComboBox.Text = vehicle.Brand + " " + vehicle.Model;
                this.BrandTextBox.Text = vehicle.Brand;
                this.ModelTextBox.Text = vehicle.Model;
                this.CategoryComboBox.Text = vehicle.Category;
                if (vehicle.ImagePath != "")
                {
                    this.VehiclePicture.Image = Utilities.GetCopyImage(vehicle.ImagePath);
                    this.ImageInfoLabel.Visible = false;
                }
                else
                {
                    VehiclePicture.Image = null;
                    this.ImageInfoLabel.Visible = true;
                }
            }
            else
            {
                this.VehicleComboBox.Text = "";
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

            //if name or brand has modified
            if (BrandTextBox.Text.ToLower().Trim() != StoredVehicle.Brand.ToLower().Trim()
             || ModelTextBox.Text.ToLower().Trim() != StoredVehicle.Model.ToLower().Trim())
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Controls.Clear();
            VehicleModel UpdatedVehicle;
            string VehicleName;
            if (StoredVehicle != null)
            {
                UpdatedVehicle = new VehicleModel(StoredVehicle);
                string filePath = StoredVehicle.ImagePath;
                if (ImageChanged)
                {
                    File.Delete(StoredVehicle.ImagePath);
                    filePath = GlobalConfig.ImageStorage.Save(VehiclePicture.Image);
                }

                UpdatedVehicle.Model = ModelTextBox.Text.Trim();
                UpdatedVehicle.Brand = BrandTextBox.Text.Trim();
                UpdatedVehicle.Category = CategoryComboBox.Text.Trim();
                UpdatedVehicle.ImagePath = filePath;

                if (VehicleChanged(UpdatedVehicle) && CheckData())
                {
                    //Remove old name from vehicle list
                    VehicleName = StoredVehicle.Brand + " " + StoredVehicle.Model;
                    VehicleIds.Remove(VehicleName);

                    //Add new name to list
                    StoredVehicle = UpdatedVehicle;
                    VehicleName = StoredVehicle.Brand + " " + StoredVehicle.Model;
                    VehicleIds[VehicleName] = StoredVehicle.Id;

                    CRUD.UpdateVehicle(UpdatedVehicle);

                    Utilities.GenerateSuccess("Vehicle successfully updated!", MessagePanel);
                    //update vehicle list
                    VehicleComboBox.DataSource = VehicleIds.Keys.OrderBy(x => x).ToList<String>();

                    if (ParentForm == Program.VehicleManagerFormInstance)
                        Program.VehicleManagerFormInstance.ReloadVehiclePanels();
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
        }

        private void DeleteVehicleButton_Click(object sender, EventArgs e)
        {
            MessagePanel.Controls.Clear();
            if (StoredVehicle != null)
            {
                string VehicleName;
                int VehicleId = StoredVehicle.Id;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle?\nThis action is permanent and will remove it from all competitions!", "Are you sure", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool vehicleDeleted;

                    vehicleDeleted = CRUD.DeleteVehicle(VehicleId);
                    if (!vehicleDeleted)
                        Utilities.GenerateError("Vehicle does not exist!", MessagePanel);
                    else
                    {
                        VehicleName = StoredVehicle.Brand + " " + StoredVehicle.Model;
                        VehicleIds.Remove(VehicleName);
                        VehicleComboBox.DataSource = VehicleIds.Keys.OrderBy(x => x).ToList<String>();
                        LoadVehicle();
                        StoredVehicle = null;
                        Utilities.GenerateSuccess("Vehicle deleted!", MessagePanel);
                        if(ParentForm == Program.VehicleManagerFormInstance)
                            Program.VehicleManagerFormInstance.ReloadVehiclePanels();
                    }
                    
                }
            }
            else
            {
                Utilities.GenerateError("No vehicle to delete!", MessagePanel);
            }
        }
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

        private void VehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CurrentVehicleId = VehicleIds[VehicleComboBox.Text];
            VehicleModel CurrentVehicle = GetVehicleById(CurrentVehicleId);

            LoadVehicle(CurrentVehicle);
        }

        private static VehicleModel GetVehicleById(int id)
        {
            VehicleModel SearchedVehicle;

            SearchedVehicle = CRUD.GetVehicleById(id);

            return SearchedVehicle;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            foreach(String vehicleName in VehicleIds.Keys)
                if(VehicleComboBox.Text.ToLower().Trim() == vehicleName.ToLower())
                {
                    VehicleModel SelectedVehicle = GetVehicleById(VehicleIds[vehicleName]);
                    StoredVehicle = SelectedVehicle;
                    LoadVehicle(SelectedVehicle);
                    return;   
                }
            //if at this point the function did not stop, vehicle was not found
            Utilities.GenerateError("Vehicle not found!", MessagePanel);

            //TODO - Add functionality for partial matches.
        }

        private void VehicleUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Enabled = true;
            ParentForm.BringToFront();
        }
    }
}
