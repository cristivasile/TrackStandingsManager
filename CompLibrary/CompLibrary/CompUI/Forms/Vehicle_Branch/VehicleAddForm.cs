using CompLibrary;
using CompLibrary.Storage_Management;
using CompUI.Forms;
using CompUI.Forms.Templates;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CompUI
{

    public partial class VehicleAddForm : TemplateFormNotResizable
    {
        /// <summary>
        /// last image received from clipboard
        /// </summary>
        private Image lastImageInserted;
        private readonly new Form ParentForm;

        public VehicleAddForm(Form sender)
        {
            ParentForm = sender;
            InitializeComponent();
            InitializeBorder();
            CategoryComboBox.DataSource = GlobalData.Categories;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string imagePath = "";
                if(VehiclePicture.Image != null)
                {
                    imagePath = GlobalConfig.ImageStorage.Save(lastImageInserted);
                }

                //creates a new vehicle with the data provided
                VehicleModel newVehicle = new(
                    BrandTextBox.Text.Trim(),
                    ModelTextBox.Text.Trim(),
                    CategoryComboBox.Text.Trim(),
                    imagePath
                    );
                    
                //check if category exists
                bool categoryAdded = CRUD.CreateCategory(CategoryComboBox.Text.Trim());

                //if successful, display message
                if(categoryAdded)
                Utilities.GenerateSuccess("Category created!", MessagePanel);
                    
                //add vehicle to json and list
                CRUD.CreateVehicle(newVehicle);

                //alerts the user that the insert is done
                Utilities.GenerateSuccess("Insert successful!", MessagePanel);

                //clears all fields
                BrandTextBox.Text = "";
                ModelTextBox.Text = "";
                CategoryComboBox.Text = "";

                //resets image info label
                ImageInfoLabel.Text = "Click to paste \nimage from clipboard";

                //resets image frame
                VehiclePicture.Image = null;

                if(ParentForm == Program.VehicleManagerFormInstance)
                    Program.VehicleManagerFormInstance.ReloadVehiclePanels();
            }
        }

        /// <summary>
        /// Checks whether the data in the form is correct or not
        /// </summary>
        /// <returns>True if data is valid or false otherwise</returns>
        private bool CheckData()
        {
            bool status = true;

            // Brand information check
            if(string.IsNullOrEmpty(BrandTextBox.Text)) 
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
            foreach(VehicleModel vehicle in GlobalData.Vehicles)
                if(vehicle.Brand.ToLower().Trim() + vehicle.Model.ToLower().Trim() == 
                    BrandTextBox.Text.ToLower().Trim() + ModelTextBox.Text.ToLower().Trim())
                {
                    Utilities.GenerateError("Vehicle already exists!", MessagePanel);
                    status = false;
                }

            return status;
        }

        private void RemoveCategoryButton_Click(object sender, EventArgs e)
        {
            //if no category is selected
            if (string.IsNullOrEmpty(CategoryComboBox.Text))
            {
                MessagePanel.Controls.Clear();
                Utilities.GenerateError("Cannot delete empty category!", MessagePanel);
            }
            else
            {
                DialogResult userChoice = MessageBox.Show("Are you sure you want to delete this category?\nNote: This will not remove it from existing vehicles.", "Category deletion", MessageBoxButtons.YesNo);
                if(userChoice == DialogResult.Yes)
                {
                    bool wasDeleted;

                    wasDeleted = CRUD.DeleteCategory(CategoryComboBox.Text);

                    MessagePanel.Controls.Clear();
                    if (wasDeleted)
                    {
                        Utilities.GenerateSuccess("Category deleted!", MessagePanel);
                    }
                    else
                    {
                        Utilities.GenerateError("Category does not exist!", MessagePanel);
                    }
                    CategoryComboBox.DataSource = GlobalData.Categories;
                }
            }
        }

        private void VehiclePicture_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, VehiclePicture.ClientRectangle, 
                Color.FromArgb(200, 246, 255), 3, ButtonBorderStyle.Solid,  //left
                Color.FromArgb(200, 246, 255), 3, ButtonBorderStyle.Solid,  //top
                Color.FromArgb(228, 246, 255), 3, ButtonBorderStyle.Solid,  //right
                Color.FromArgb(228, 246, 255), 3, ButtonBorderStyle.Solid); //bottom
        }

        private void VehiclePicture_Click(object sender, EventArgs e)
        {
            //if there's an image in clipboard
            if (Clipboard.ContainsImage())
            {
                VehiclePicture.Image = Clipboard.GetImage();
                lastImageInserted = Clipboard.GetImage();

                //make the image fit the box
                VehiclePicture.ResizeToFit();

                //Removes info label
                ImageInfoLabel.Text = "";

                VehiclePicture.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("No image in clipboard", "Error", MessageBoxButtons.OK);
            }
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


        private void VehicleAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Enabled = true;
            if (ParentForm == Program.EntryInsertFormInstance)
            {
                Program.EntryInsertFormInstance.Enabled = true;
                Program.EntryInsertFormInstance.Show();
                Program.EntryInsertFormInstance.InitializeVehicles();
            }
            else if (ParentForm == Program.EntryUpdateFormInstance)
            {
                Program.EntryUpdateFormInstance.Enabled = true;
                Program.EntryUpdateFormInstance.Show();
                Program.EntryUpdateFormInstance.InitializeVehicles();
            }
            ParentForm.BringToFront();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
