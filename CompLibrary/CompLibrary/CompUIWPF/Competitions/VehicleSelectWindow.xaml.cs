using CompLibrary;
using CompLibrary.Storage_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CompUIWPF.Vehicles; // Assuming this is where VehicleModel lives, though not explicitly shown

namespace CompUIWPF.Competitions
{
    public partial class VehicleSelectWindow : Window
    {
        public int SelectedVehicleId { get; private set; } = -1;

        // Changed type to the display item class
        private List<VehicleDisplayItem> _allDisplayItems = [];

        private static string _lastSearch = "";

        private readonly int _competitionId;
        private readonly CompetitionModel _competition;

        public class VehicleDisplayItem // Defined outside the window class for access.
        {
            public int Id { get; set; }
            public string Brand { get; set; } = "";
            public string Model { get; set; } = "";
            public string ScoreText { get; set; } = "";
            public string ImagePath { get; set; } = "";
        }

        public VehicleSelectWindow(int competitionId)
        {
            InitializeComponent();

            // Load competition info
            _competitionId = competitionId;
            _competition = CRUD.GetCompetitionById(_competitionId);

            LoadVehicles();
            SearchBox.TextChanged += SearchBox_TextChanged;

            // restore saved search
            SearchBox.Text = _lastSearch;

            // reapply filter
            ApplySearchFilter(_lastSearch);
        }

        private void LoadVehicles()
        {
            // We now populate the ListBox with VehicleDisplayItem objects
            _allDisplayItems = [.. GlobalData.Vehicles.Values
                .Select(v =>
                {
                    // Check if the vehicle has an existing entry
                    var entry = CRUD.GetCompetitorByCompetitionAndVehicleId(_competition, v.Id);
                    string scoreText;

                    if (entry == null)
                        scoreText = "";
                    else if (double.IsInfinity(entry.Score))
                        scoreText = "DNF";
                    else if (_competition.PlacementType == 1)
                        scoreText = $"{entry.Score} pts";
                    else
                        scoreText = FunctionLibrary.GetTimeString(entry.Score);

                    // Create the VehicleDisplayItem, including the ImagePath and calculated ScoreText
                    return new VehicleDisplayItem
                    {
                        Id = v.Id,
                        Brand = v.Brand,
                        Model = v.Model,
                        ScoreText = scoreText,
                        ImagePath = v.ImagePath // Pass the image path from the original model
                    };
                })
                .OrderBy(v => v.Brand + v.Model)];

            VehicleGrid.ItemsSource = _allDisplayItems;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _lastSearch = SearchBox.Text;   // ✅ save search

            ApplySearchFilter(_lastSearch);
        }

        private void ApplySearchFilter(string query)
        {
            query = query?.ToLower() ?? "";

            // Filter the list of VehicleDisplayItem objects based on BrandModel
            var filtered = _allDisplayItems
                .Where(v => (v.Brand + " " + v.Model)
                .Contains(query, StringComparison.CurrentCultureIgnoreCase))
                .ToList();

            VehicleGrid.ItemsSource = filtered;
        }

        private void VehicleGrid_MouseDown(object sender, RoutedEventArgs e)
        {
            // The Tag property is correctly bound to the Id of the VehicleDisplayItem
            if (sender is Border brdr && brdr.Tag is int id)
            {
                SelectedVehicleId = id;
                DialogResult = true;
                Close();
            }
        }
    }
}