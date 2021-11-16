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
    public partial class FilterForm : Form
    {

        private HashSet<string> FilteredElements = new();
        public HashSet<string> Result = new();
        int filterin;


        /// <param name="filterin"> - Filter location 0 = Vehicles, 1 = Competitions</param>
        /// <param name="filterby"> - Filter by 0 = Brand, 1 = Category</param>
        public FilterForm(int filterin, int filterby)
        {
            this.filterin = filterin;

            InitializeComponent();

            if (filterin == 0)
            {
                if (filterby == 0)
                    FilterLabel.Text = "Filtering by brand";
                else
                    FilterLabel.Text = "Filtering by category";

                foreach (VehicleModel vehicle in GlobalData.Vehicles)
                    if (filterby == 0)
                        FilteredElements.Add(vehicle.Brand);
                    else FilteredElements.Add(vehicle.Category);
            }

            FilterCheckedListBox.DataSource = FilteredElements.ToList();
            SetAllCheckedListBox(true);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (filterin == 0)
            {
                Program.VehicleManagerFormInstance.Enabled = true;
                Program.VehicleManagerFormInstance.BringToFront();
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

        private void FilterForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // ------ //


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void SetAllCheckedListBox(bool checkState) {
            for (int i = 0; i < FilterCheckedListBox.Items.Count; i++)
                FilterCheckedListBox.SetItemChecked(i, checkState);
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAll.Checked)
                SetAllCheckedListBox(true);
            else 
                SetAllCheckedListBox(false);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterCheckedListBox.CheckedItems.Count == 0)
                MessageBox.Show("You must choose at least one item!", "Error");
            else
            {
                for (int i = 0; i < FilterCheckedListBox.Items.Count; i++)
                    if (FilterCheckedListBox.GetItemChecked(i))
                        Result.Add(FilterCheckedListBox.Items[i].ToString());

                this.Close();
                if (filterin == 0)
                {
                    Program.VehicleManagerFormInstance.Enabled = true;
                    Program.VehicleManagerFormInstance.BringToFront();
                    Program.VehicleManagerFormInstance.ReloadForm();
                }
            }

        }
    }
}
