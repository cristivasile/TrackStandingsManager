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
    public partial class VehicleUpdateForm : Form
    {
        public VehicleUpdateForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VehicleUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void VehicleUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
