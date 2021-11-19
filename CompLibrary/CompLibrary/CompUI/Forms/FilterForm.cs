using CompLibrary;
using CompUI.Forms.Templates;
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
    public partial class FilterForm : TemplateFormNotResizable
    {

        private HashSet<string> FilteredElements = new();
        public HashSet<string> Result = new();
        private new Form ParentForm;

        /// <param name="filterby"> - Filter by 0 = Brand, 1 = Category</param>
        public FilterForm(int filterby, Form sender)
        {
            ParentForm = sender;

            InitializeComponent();
            InitializeBorder();

            if (ParentForm == Program.VehicleManagerFormInstance)
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
            else if (FilterCheckedListBox.CheckedItems.Count == FilteredElements.Count)
                MessageBox.Show("You need to uncheck at least one item!", "Error");
            else
            {
                for (int i = 0; i < FilterCheckedListBox.Items.Count; i++)
                    if (FilterCheckedListBox.GetItemChecked(i))
                        Result.Add(FilterCheckedListBox.Items[i].ToString());

                this.Close();
                if (ParentForm == Program.VehicleManagerFormInstance)
                {
                    Program.VehicleManagerFormInstance.Enabled = true;
                    Program.VehicleManagerFormInstance.BringToFront();
                    Program.VehicleManagerFormInstance.ReloadForm();
                }
            }

        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Enabled = true;
            ParentForm.BringToFront();
        }

    }
}
