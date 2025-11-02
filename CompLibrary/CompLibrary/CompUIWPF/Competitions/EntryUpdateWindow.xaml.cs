using CompLibrary;
using CompLibrary.Storage_Management;
using CompUI;
using System.Linq;
using System.Windows;
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

        private void LoadData()
        {
            // Load vehicle image
            var vehicle = GlobalData.Vehicles.First(v => v.Id == _entry.VehicleId);

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

            switch (_competition.TimingType)
            {
                case -1: TimeFormatLabel.Visibility = Visibility.Collapsed; break;
                case 0: TimeFormatLabel.Text = "SS.mmm"; break;
                case 1: TimeFormatLabel.Text = "MM:SS.mmm"; break;
                case 2: TimeFormatLabel.Text = "HH:MM:SS.mmm"; break;
            }

            // Score
            ScoreBox.Text = _competition.PlacementType == 1
                ? _entry.Score.ToString()
                : FunctionLibrary.GetTimeString(_entry.Score, _competition.TimingType);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageText.Text = "";

            double score = 0;

            // Points
            if (_competition.PlacementType == 1)
            {
                if (!double.TryParse(ScoreBox.Text, out score))
                {
                    MessageText.Text = "Invalid points";
                    return;
                }
            }
            else
            {
                // Timing
                int requiredDigits = _competition.TimingType switch
                {
                    0 => 5,
                    1 => 7,
                    2 => 9,
                    _ => 5
                };

                string digits = ScoreBox.Text.FilterDigits().PadZeroes(requiredDigits);
                if (digits.Length != requiredDigits)
                {
                    MessageText.Text = "Invalid time format";
                    return;
                }

                var t = new Time();
                try
                {
                    switch (_competition.TimingType)
                    {
                        case 0:
                            t.Seconds = int.Parse(digits.Substring(0, 2));
                            t.Milliseconds = int.Parse(digits.Substring(2, 3));
                            break;
                        case 1:
                            t.Minutes = int.Parse(digits.Substring(0, 2));
                            t.Seconds = int.Parse(digits.Substring(2, 2));
                            t.Milliseconds = int.Parse(digits.Substring(4, 3));
                            break;
                        case 2:
                            t.Hours = int.Parse(digits.Substring(0, 2));
                            t.Minutes = int.Parse(digits.Substring(2, 2));
                            t.Seconds = int.Parse(digits.Substring(4, 2));
                            t.Milliseconds = int.Parse(digits.Substring(6, 3));
                            break;
                    }

                    score = t.GetTimeInSeconds();
                }
                catch
                {
                    MessageText.Text = "Invalid time format";
                    return;
                }
            }

            // Save entry
            var updated = new CompetitorModel(_entry.VehicleId, score, AuthorTextBox.Text.Trim())
            {
                Id = _entry.Id
            };

            CRUD.UpdateCompetitor(_competitionId, updated);

            GlobalEvents.RaiseCompetitionEntriesChanged();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();
    }
}
