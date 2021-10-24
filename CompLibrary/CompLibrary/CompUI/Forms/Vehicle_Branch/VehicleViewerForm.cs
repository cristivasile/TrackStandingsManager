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
        public VehicleViewerForm()
        {
            InitializeComponent();
        }

        private void FilterByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VehicleViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.VehicleManagerFormInstance.Show();
        }
    }
}
