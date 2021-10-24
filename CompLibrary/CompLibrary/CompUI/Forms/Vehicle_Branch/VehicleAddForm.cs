using CompLibrary;
using System;
using System.Drawing;
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
                    brandTextBox.Text.Trim(),
                    modelTextBox.Text.Trim(),
                    categoryComboBox.Text.Trim()
                    );


                //stores data in each storage object
                foreach (IDataConnection storage in GlobalConfig.Connections)
                {
                    
                    //check if category exists
                    bool categoryAdded = storage.CreateCategory(categoryComboBox.Text.Trim());

                    //if successful, display message
                    if(categoryAdded)
                    Utilities.generateSuccess("Category created!", messagePanel);
                    
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
                if((vehicle.Brand.ToLower().Trim()==brandTextBox.Text.ToLower().Trim())
                  &&vehicle.Model.ToLower().Trim()== modelTextBox.Text.ToLower().Trim())
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

        private void vehiclePicture_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, vehiclePicture.ClientRectangle, 
                Color.FromArgb(200, 246, 255), 3, ButtonBorderStyle.Solid,  //left
                Color.FromArgb(200, 246, 255), 3, ButtonBorderStyle.Solid,  //top
                Color.FromArgb(228, 246, 255), 3, ButtonBorderStyle.Solid,  //right
                Color.FromArgb(228, 246, 255), 3, ButtonBorderStyle.Solid); //bottom
        }

        private void vehiclePicture_Click(object sender, EventArgs e)
        {
            //if there's an image in clipboard
            if (Clipboard.ContainsImage())
            {
                vehiclePicture.Image = Clipboard.GetImage();


                //for maintaining aspect ratio;
                double ratio;
                //if image is wider than a square
                if (vehiclePicture.Image.Width > vehiclePicture.Image.Height)
                {
                    ratio = Convert.ToDouble(vehiclePicture.Image.Height) / Convert.ToDouble(vehiclePicture.Image.Width);
                    vehiclePicture.Image = Utilities.ResizeImage(vehiclePicture.Image, vehiclePicture.Width, Convert.ToInt32(ratio*vehiclePicture.Height));
                }
                //else if image is taller than a square
                else
                {
                    ratio = Convert.ToDouble(vehiclePicture.Image.Width) / Convert.ToDouble(vehiclePicture.Image.Height);
                    vehiclePicture.Image = Utilities.ResizeImage(vehiclePicture.Image, Convert.ToInt32(ratio *vehiclePicture.Width), vehiclePicture.Height);

                }

                //Removes info label
                imageInfoLabel.Text = "";


                //empties hover and leave events
                vehiclePicture.MouseHover -= vehiclePicture_MouseHover;
                vehiclePicture.MouseLeave -= vehiclePicture_MouseLeave;

                //TODO - save the image to disk and path to JSON
            }
            else
            {
                MessageBox.Show("No image in clipboard", "Error", MessageBoxButtons.OK);
            }
        }

        private void vehiclePicture_MouseHover(object sender, EventArgs e)
        {
            vehiclePicture.BackColor = Color.Silver;
            imageInfoLabel.BackColor = Color.Silver;
        }

        private void vehiclePicture_MouseLeave(object sender, EventArgs e)
        {
            vehiclePicture.BackColor = Color.White;
            imageInfoLabel.BackColor = Color.White;
        }



        //source https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        // ------ //

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void VehicleAddForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // ------ //
    }
}
