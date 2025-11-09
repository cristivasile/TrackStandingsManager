using CompLibrary;
using CompLibrary.Storage_Management;
using CompUIWPF.Vehicles;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CompUIWPF.Competitions
{
    public partial class EntryAddWindow : Window
    {
        private readonly int _competitionId;
        private readonly CompetitionModel _competition;
        private readonly System.Collections.Generic.Dictionary<string, int> _vehicleIds = [];
        private ICollectionView _vehicleView;

        public string CompetitionName { get; set; }

        public EntryAddWindow(int competitionId)
        {
            InitializeComponent();
            _competitionId = competitionId;

            // Load competition info
            _competition = CRUD.GetCompetitionById(_competitionId);
            CompetitionName = _competition.Name;
            DataContext = this;

            // Setup scoring type
            ScoringLabel.Text = _competition.PlacementType == 0 ? "Time" : "Points";

            // Populate vehicles
            foreach (var v in GlobalData.Vehicles.Values)
                _vehicleIds[v.Brand + " " + v.Model] = v.Id;

            VehicleBox.ItemsSource = GlobalData.Vehicles.Values
                .Select(v => new { v.Id, BrandModel = v.Brand + " " + v.Model })
                .OrderBy(v => v.BrandModel)
                .ToList();

            // Set up filterable view
            _vehicleView = CollectionViewSource.GetDefaultView(VehicleBox.ItemsSource);
            VehicleBox.IsTextSearchEnabled = false;
            VehicleBox.StaysOpenOnEdit = true;
            VehicleBox.IsEditable = true;
            VehicleBox.PreviewKeyUp += VehicleBox_PreviewKeyUp;

            GlobalEvents.VehiclesChanged += OnVehiclesChanged;
        }

        ~EntryAddWindow()
        {
            GlobalEvents.VehiclesChanged -= OnVehiclesChanged;
        }

        private void ShowMessage(string text, bool success)
        {
            MessagePanel.Children.Clear();

            var tb = new TextBlock
            {
                Text = text,
                Foreground = success
                    ? new SolidColorBrush(Colors.Green)
                    : new SolidColorBrush(Colors.IndianRed),
                FontWeight = FontWeights.SemiBold,
                Margin = new Thickness(0, 4, 0, 0),
                TextWrapping = TextWrapping.Wrap
            };

            MessagePanel.Children.Add(tb);
        }

        private void VehicleBox_PreviewKeyUp(object sender, RoutedEventArgs e)
        {
            string text = VehicleBox.Text.ToLower();

            _vehicleView.Filter = o =>
            {
                dynamic v = o;
                return v.BrandModel.ToLower().Contains(text);
            };
            _vehicleView.Refresh();

            VehicleBox.IsDropDownOpen = true;
            VehicleBox.SelectedIndex = -1;
        }

        private void VehicleBox_Loaded(object sender, RoutedEventArgs e)
        {
            VehicleBox.SelectedIndex = -1;
        }

        private void OnVehiclesChanged()
        {
            _vehicleIds.Clear();
            foreach (var v in GlobalData.Vehicles.Values)
                _vehicleIds[v.Brand + " " + v.Model] = v.Id;

            var list = GlobalData.Vehicles.Values
                .Select(v => new { v.Id, BrandModel = v.Brand + " " + v.Model })
                .OrderBy(v => v.BrandModel)
                .ToList();

            VehicleBox.ItemsSource = list;

            _vehicleView = CollectionViewSource.GetDefaultView(VehicleBox.ItemsSource);
            _vehicleView.Filter = null;
            _vehicleView.Refresh();

            VehicleBox.Text = string.Empty;
            VehicleBox.SelectedIndex = -1;

            VehicleImage.Source = null;
            VehicleImage.Visibility = Visibility.Collapsed;
        }

        private void VehicleAddButton_Click(object sender, RoutedEventArgs e)
        {
            var vehicleAddWindow = new AddVehicleWindow
            {
                ShowInTaskbar = true,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            var parent = Window.GetWindow(this);
            parent.IsEnabled = false;

            void closingHandler(object? s, CancelEventArgs args)
            {
                if (vehicleAddWindow != null && vehicleAddWindow.IsVisible)
                {
                    args.Cancel = true;
                    vehicleAddWindow.Activate();
                }
            }
            parent.Closing += closingHandler;

            vehicleAddWindow.Closed += (s, args) =>
            {
                parent.IsEnabled = true;
                parent.Activate();
                parent.Closing -= closingHandler;
            };

            vehicleAddWindow.Show();
        }

        private void LoadVehicleImage(VehicleModel vehicle)
        {
            if (!string.IsNullOrWhiteSpace(vehicle.ImagePath))
            {
                try
                {
                    VehicleImage.Source = new BitmapImage(new Uri(vehicle.ImagePath, UriKind.RelativeOrAbsolute));
                    VehicleImage.Visibility = Visibility.Visible;
                }
                catch
                {
                    VehicleImage.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                VehicleImage.Source = null;
                VehicleImage.Visibility = Visibility.Collapsed;
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            ShowMessage("", false);

            if (string.IsNullOrEmpty(VehicleBox.Text))
            {
                ShowMessage("Choose vehicle", false);
                return;
            }

            if (!_vehicleIds.TryGetValue(VehicleBox.Text, out int vid))
            {
                ShowMessage("Vehicle does not exist", false);
                return;
            }

            double score = 0;
            bool couldComplete = !DNFCheckBox.IsChecked.GetValueOrDefault(false);

            if (couldComplete)
            {
                if (_competition.PlacementType == 1)
                {
                    if (!double.TryParse(ScoreBox.Text, out score))
                    {
                        ShowMessage("Invalid points", false);
                        return;
                    }
                }
                else
                {
                    string input = ScoreBox.Text.Trim();
                    if (!Utilities.ExtractTimeIfValid(input, out score))
                    {
                        ShowMessage("Invalid time format. Valid formats: SS.mmm, MM:SS.mmm, HH:MM:SS.mmm", false);
                        return;
                    }
                }
            }
            else
            {
                // Set score to placeholder; CRUD.CreateCompetitor will convert to infinity
                score = 0;
            }

            var entry = new CompetitorModel(vid, score, DateTime.Now);
            CRUD.CreateCompetitor(_competitionId, entry, couldComplete);

            GlobalEvents.RaiseCompetitionEntriesChanged();
            GlobalEvents.RaiseVehiclesChanged();

            ScoreBox.Text = "";
            DNFCheckBox.IsChecked = false;

            ShowMessage("Entry created!", true);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();

        private void VehicleBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (VehicleBox.SelectedItem == null) return;

            dynamic selected = VehicleBox.SelectedItem;
            int id = selected.Id;

            var vehicle = CRUD.GetVehicleById(id);
            LoadVehicleImage(vehicle);
        }

        private void VehicleSelectButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new VehicleSelectWindow
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                WindowState = WindowState.Maximized
            };

            if (win.ShowDialog() == true && win.SelectedVehicleId != -1)
            {
                var vehicle = CRUD.GetVehicleById(win.SelectedVehicleId);
                if (vehicle != null)
                {
                    string label = vehicle.Brand + " " + vehicle.Model;
                    VehicleBox.Text = label;
                    VehicleBox.SelectedValue = vehicle.Id;
                    LoadVehicleImage(vehicle);
                }
            }
        }

        private void DNFCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Disable score input
            ScoreBox.IsEnabled = false;
            ScoreBox.Text = ""; // Clear current score
        }

        private void DNFCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Re-enable score input
            ScoreBox.IsEnabled = true;
        }
    }
}
