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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void VehicleManagerForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
