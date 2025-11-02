using CompLibrary;
using CompLibrary.Storage_Management;
using CompUI;
using CompUIWPF.Vehicles;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CompUIWPF.Competitions
{
    public partial class EntryAddWindow : Window
    {
        private readonly int _competitionId;
        private CompetitionModel _competition;
        private readonly System.Collections.Generic.Dictionary<string, int> _vehicleIds = new();
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
            switch (_competition.TimingType)
            {
                case -1: TimeFormatLabel.Visibility = Visibility.Collapsed; break;
                case 0: TimeFormatLabel.Text = "SS.mmm"; break;
                case 1: TimeFormatLabel.Text = "MM:SS.mmm"; break;
                case 2: TimeFormatLabel.Text = "HH:MM:SS.mmm"; break;
            }

            // Populate vehicles
            foreach (var v in GlobalData.Vehicles)
                _vehicleIds[v.Brand + " " + v.Model] = v.Id;

            VehicleBox.ItemsSource = GlobalData.Vehicles.Select(v => new { v.Id, BrandModel = v.Brand + " " + v.Model }).ToList();

            // Set up filterable view
            _vehicleView = CollectionViewSource.GetDefaultView(VehicleBox.ItemsSource);
            VehicleBox.IsTextSearchEnabled = false; // we handle filtering ourselves
            VehicleBox.StaysOpenOnEdit = true;
            VehicleBox.IsEditable = true;
            VehicleBox.PreviewKeyUp += VehicleBox_PreviewKeyUp;

            GlobalEvents.VehiclesChanged += OnVehiclesChanged;
        }
        ~EntryAddWindow()
        {
            GlobalEvents.VehiclesChanged -= OnVehiclesChanged;
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

            // prevent auto-selection when typing
            VehicleBox.SelectedIndex = -1;
        }

        private void VehicleBox_Loaded(object sender, RoutedEventArgs e)
        {
            VehicleBox.SelectedIndex = -1;
        }

        private void OnVehiclesChanged()
        {
            // Rebuild dictionary
            _vehicleIds.Clear();
            foreach (var v in GlobalData.Vehicles)
                _vehicleIds[v.Brand + " " + v.Model] = v.Id;

            // Rebuild ItemsSource
            var list = GlobalData.Vehicles
                .Select(v => new { v.Id, BrandModel = v.Brand + " " + v.Model })
                .ToList();

            VehicleBox.ItemsSource = list;

            // Recreate view and filter handler
            _vehicleView = CollectionViewSource.GetDefaultView(VehicleBox.ItemsSource);
            _vehicleView.Filter = null;
            _vehicleView.Refresh();

            // Clear selection + text
            VehicleBox.Text = string.Empty;
            VehicleBox.SelectedIndex = -1;

            // Hide previous image
            VehicleImage.Source = null;
            VehicleImage.Visibility = Visibility.Collapsed;
        }

        private void VehicleAddButton_Click(object sender, RoutedEventArgs e)
        {
            var _addWindow = new AddVehicleWindow
            {
                ShowInTaskbar = true,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            var parent = Window.GetWindow(this);
            parent.IsEnabled = false; // block parent

            // Prevent parent from closing while child is open
            void closingHandler(object? s, CancelEventArgs args)
            {
                if (_addWindow != null && _addWindow.IsVisible)
                {
                    args.Cancel = true; // block the close
                    _addWindow.Activate(); // bring child forward
                }
            }
            parent.Closing += closingHandler;

            _addWindow.Closed += (s, args) =>
            {
                parent.IsEnabled = true; // re-enable parent
                parent.Activate();       // bring parent back to front
                parent.Closing -= closingHandler; // remove handler
            };

            _addWindow.Show();
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
            MessageText.Text = "";
            if (string.IsNullOrEmpty(VehicleBox.Text)) { MessageText.Text = "Choose vehicle"; return; }
            if (!_vehicleIds.ContainsKey(VehicleBox.Text)) { MessageText.Text = "Vehicle does not exist"; return; }

            int vid = _vehicleIds[VehicleBox.Text];
            double score = 0;

            if (_competition.PlacementType == 1)
            {
                if (!double.TryParse(ScoreBox.Text, out score)) { MessageText.Text = "Invalid points"; return; }
            }
            else // Timing
            {
                int requiredDigits = _competition.TimingType switch
                {
                    0 => 5,
                    1 => 7,
                    2 => 9,
                    _ => 5
                };
                string digits = ScoreBox.Text.FilterDigits().PadZeroes(requiredDigits);
                if (digits.Length != requiredDigits) { MessageText.Text = "Invalid time format"; return; }

                var competitorTime = new Time();
                try
                {
                    switch (_competition.TimingType)
                    {
                        case 0:
                            competitorTime.Seconds = int.Parse(digits.Substring(0, 2));
                            competitorTime.Milliseconds = int.Parse(digits.Substring(2, 3));
                            break;
                        case 1:
                            competitorTime.Minutes = int.Parse(digits.Substring(0, 2));
                            competitorTime.Seconds = int.Parse(digits.Substring(2, 2));
                            competitorTime.Milliseconds = int.Parse(digits.Substring(4, 3));
                            break;
                        case 2:
                            competitorTime.Hours = int.Parse(digits.Substring(0, 2));
                            competitorTime.Minutes = int.Parse(digits.Substring(2, 2));
                            competitorTime.Seconds = int.Parse(digits.Substring(4, 2));
                            competitorTime.Milliseconds = int.Parse(digits.Substring(6, 3));
                            break;
                    }
                    score = competitorTime.GetTimeInSeconds();
                }
                catch { MessageText.Text = "Invalid time format"; return; }
            }

            var entry = new CompetitorModel(vid, score, AuthorTextBox.Text.Trim());
            CRUD.CreateCompetitor(_competitionId, entry);

            // Notify entries changed
            GlobalEvents.RaiseCompetitionEntriesChanged();

            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();

        private void VehicleBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (VehicleBox.SelectedItem == null) return;

            dynamic selected = VehicleBox.SelectedItem;
            string brandModel = selected.BrandModel;
            int id = selected.Id;

            var vehicle = CRUD.GetVehicleById(id);
            LoadVehicleImage(vehicle);
        }

        private void VehicleBox_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
