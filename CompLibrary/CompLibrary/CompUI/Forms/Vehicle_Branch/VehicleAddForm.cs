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

namespace CompUI
{
    public partial class VehicleAddForm : Form
    {
        public VehicleAddForm()
        {
            InitializeComponent();
            categoryComboBox.DataSource = GlobalData.categories;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                //TODO - add image functionality
                //creates a new vehicle with the data provided
                VehicleModel newVehicle = new VehicleModel(
                    brandTextBox.Text,
                    modelTextBox.Text,
                    categoryComboBox.Text
                    );



                //stores data in each storage object
                foreach (IDataConnection storage in GlobalConfig.Connections)
                {
                    
                    //check if category exists
                    bool categoryAdded = storage.CreateCategory(categoryComboBox.Text);

                    //if successful, display message
                    if(categoryAdded)
                    Utilities.generateSuccess("Category added!", messagePanel);
                    

                    //add vehicle to json and list
                    storage.CreateVehicle(newVehicle);
                }

                //alerts the user that the insert is done
                Utilities.generateSuccess("Insert successful!", messagePanel);

                //clears all fields
                brandTextBox.Text = "";
                modelTextBox.Text = "";
                categoryComboBox.Text = "";
            }
        }

        /// <summary>
        /// Checks whether the data in the form is correct or not
        /// </summary>
        /// <returns>True if data is valid or false otherwise</returns>
        private bool checkData()
        {
            bool status = true;

            // Deals with previous errors
            messagePanel.Controls.Clear();

            // Brand information check
            if(string.IsNullOrEmpty(brandTextBox.Text)) 
            {
                Utilities.generateError("Brand can not be empty!", messagePanel);
                status = false;
            }

            // Model information check
            if (string.IsNullOrEmpty(modelTextBox.Text))
            {
                Utilities.generateError("Model can not be empty!", messagePanel);
                status = false;
            }

            // Category information check
            if (string.IsNullOrEmpty(categoryComboBox.Text))
            {
                Utilities.generateError("Category can not be empty!", messagePanel);
                status = false;
            }


            //check if vehicle with this name already exists
            foreach(VehicleModel vehicle in GlobalData.vehicles)
                if((vehicle.Brand.ToLower()==brandTextBox.Text.ToLower())
                  &&vehicle.Model.ToLower()==modelTextBox.Text.ToLower())
                {
                    Utilities.generateError("Vehicle already exists!", messagePanel);
                    status = false;
                }

            return status;
        }


        private void abortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeCategoryButton_Click(object sender, EventArgs e)
        {
            //if no category is selected
            if (string.IsNullOrEmpty(categoryComboBox.Text))
            {
                messagePanel.Controls.Clear();
                Utilities.generateError("Cannot delete empty category!", messagePanel);
            }
            else
            {
                DialogResult userChoice = MessageBox.Show("Are you sure you want to delete this category?\nNote: This will not remove it from existing vehicles.", "Category deletion", MessageBoxButtons.YesNo);
                if(userChoice == DialogResult.Yes)
                {
                    bool wasDeleted = false;
                    foreach (IDataConnection storage in GlobalConfig.Connections)
                    {
                         wasDeleted = storage.RemoveCategory(categoryComboBox.Text);
                    }

                    messagePanel.Controls.Clear();
                    if (wasDeleted)
                    {
                        Utilities.generateSuccess("Category deleted!", messagePanel);
                    }
                    else
                    {
                        Utilities.generateError("Category does not exist!", messagePanel);
                    }
                    categoryComboBox.DataSource = GlobalData.categories;
                }
            }
        }
    }
}
