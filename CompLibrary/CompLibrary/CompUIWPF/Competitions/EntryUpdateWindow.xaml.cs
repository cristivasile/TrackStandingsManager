using CompLibrary;
using CompLibrary.Storage_Management;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CompUIWPF.Competitions
{
    public partial class EntryUpdateWindow : Window
    {
        private readonly int _competitionId;
        private readonly CompetitorModel _entry;
        private readonly CompetitionModel _competition;

        public string CompetitionName { get; set; }

        public EntryUpdateWindow(int competitionId, CompetitorModel entry)
        {
            InitializeComponent();

            _competitionId = competitionId;
            _entry = entry;

            // Load competition
            _competition = GlobalData.Competitions.First(c => c.Id == _competitionId);
            CompetitionName = _competition.Name;

            LoadData();
            DataContext = this;
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

        private void LoadData()
        {
            // Load vehicle image
            var vehicle = GlobalData.Vehicles.Values.First(v => v.Id == _entry.VehicleId);

            if (!string.IsNullOrWhiteSpace(vehicle.ImagePath))
            {
                try
                {
                    VehicleImage.Source = new BitmapImage(new Uri(vehicle.ImagePath, UriKind.RelativeOrAbsolute));
                    VehicleImage.Visibility = Visibility.Visible;
                }
                catch { VehicleImage.Visibility = Visibility.Collapsed; }
            }

            AuthorTextBox.Text = _entry.Author;

            // Scoring type
            ScoringLabel.Text = _competition.PlacementType == 0 ? "Time" : "Points";

            // Score + DNF
            if (double.IsInfinity(_entry.Score))
            {
                DNFCheckBox.IsChecked = true;
                ScoreBox.Text = "";
                ScoreBox.IsEnabled = false;
            }
            else
            {
                DNFCheckBox.IsChecked = false;
                ScoreBox.IsEnabled = true;
                ScoreBox.Text = _competition.PlacementType == 1
                    ? _entry.Score.ToString()
                    : FunctionLibrary.GetTimeString(_entry.Score);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
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
                    if (!Utilities.ExtractTimeIfValid(ScoreBox.Text.Trim(), out score))
                    {
                        ShowMessage("Invalid time format. Valid formats: SS.mmm, MM:SS.mmm, HH:MM:SS.mmm", false);
                        return;
                    }
                }
            }

            var updated = new CompetitorModel(_entry.VehicleId, score, AuthorTextBox.Text.Trim(), DateTime.Now)
            {
                Id = _entry.Id
            };

            CRUD.UpdateCompetitor(_competitionId, updated, couldComplete);

            GlobalEvents.RaiseCompetitionEntriesChanged();
            GlobalEvents.RaiseVehiclesChanged();
            Close();
        }


        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();

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
