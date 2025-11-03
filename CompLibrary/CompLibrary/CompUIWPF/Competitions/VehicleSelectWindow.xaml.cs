using CompLibrary;
using CompLibrary.Storage_Management;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CompUIWPF.Competitions
{
    public partial class VehicleSelectWindow : Window
    {
        public int SelectedVehicleId { get; private set; } = -1;
        private List<VehicleModel> _allVehicles = [];
        private static string _lastSearch = "";

        public VehicleSelectWindow()
        {
            InitializeComponent();
            LoadVehicles();
            SearchBox.TextChanged += SearchBox_TextChanged;

            // restore saved search
            SearchBox.Text = _lastSearch;

            // reapply filter
            ApplySearchFilter(_lastSearch);
        }

        private void LoadVehicles()
        {
            _allVehicles = [.. GlobalData.Vehicles.Values];
            VehicleGrid.ItemsSource = _allVehicles;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _lastSearch = SearchBox.Text;   // ✅ save search

            ApplySearchFilter(_lastSearch);
        }

        private void ApplySearchFilter(string query)
        {
            query = query?.ToLower() ?? "";

            var filtered = _allVehicles
                .Where(v => (v.Brand + " " + v.Model)
                .Contains(query, StringComparison.CurrentCultureIgnoreCase))
                .ToList();

            VehicleGrid.ItemsSource = filtered;
        }

        private void VehicleGrid_MouseDown(object sender, RoutedEventArgs e)
        {
            if (sender is Border brdr && brdr.Tag is int id)
            {
                SelectedVehicleId = id;
                DialogResult = true;
                Close();
            }
        }
    }
}