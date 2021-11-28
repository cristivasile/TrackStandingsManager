using CompLibrary;
using CompUI.Forms.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CompUI.Forms
{
    public partial class FilterForm : TemplateFormNotResizable
    {

        private HashSet<string> FilterElements = new();
        public HashSet<string> Result = new();
        private readonly new Form ParentForm;

        /// <param name="filterby"> - Filter by 0 = Brand, 1 = Category</param>
        public FilterForm(int filterby, Form sender)
        {
            ParentForm = sender;

            InitializeComponent();
            InitializeBorder();
            InitializeFilterElements(filterby);
            if (filterby == 0)
                FilterLabel.Text = "Filtering by brand";
            else
                FilterLabel.Text = "Filtering by category";
            SetAllCheckedListBox(true);
        }

        private void InitializeFilterElements(int filterby)
        {
            if (ParentForm == Program.VehicleManagerFormInstance)
            {
                foreach (VehicleModel vehicle in GlobalData.Vehicles)
                    if (filterby == 0)
                        FilterElements.Add(vehicle.Brand);
                    else FilterElements.Add(vehicle.Category);
            }
            else if (ParentForm == Program.CompetitionManagerFormInstance)
            {
                Dictionary<int, int> VehicleIdsToIndexes = FunctionLibrary.MapVehicleIdsToIndexes();

                foreach (CompetitorModel competitor in Program.CompetitionManagerFormInstance.CurrentCompetition.Competitors)
                    if (filterby == 0)
                        FilterElements.Add(GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]].Brand);
                    else
                        FilterElements.Add(GlobalData.Vehicles[VehicleIdsToIndexes[competitor.VehicleId]].Category);
            }

            FilterCheckedListBox.Items.Clear();
            foreach (string element in FilterElements)
                FilterCheckedListBox.Items.Add(element);
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
            else if (FilterCheckedListBox.CheckedItems.Count == FilterElements.Count)
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
                    Program.VehicleManagerFormInstance.ReloadVehiclePanels();
                }
                if (ParentForm == Program.CompetitionManagerFormInstance)
                {
                    Program.CompetitionManagerFormInstance.Enabled = true;
                    Program.CompetitionManagerFormInstance.BringToFront();
                    Program.CompetitionManagerFormInstance.ReloadVehiclePanels();
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
