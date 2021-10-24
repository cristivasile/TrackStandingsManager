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
    public partial class VehicleManagerForm : Form
    {
        public VehicleManagerForm()
        {
            InitializeComponent();
        }

        private void VehicleManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainMenuFormInstance.Show();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            Program.VehicleAddFormInstance = new();
            Program.VehicleAddFormInstance.Show();
            this.Enabled = false;
        }

        private void SeeVehiclesButton_Click(object sender, EventArgs e)
        {
            Program.VehicleViewerFormInstance = new();
            Program.VehicleViewerFormInstance.Show();
            this.Hide();
        }
    }
}
