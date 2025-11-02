using CompLibrary;
using CompLibrary.Storage_Management;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace CompUIWPF.Competitions
{
    public partial class AddCompetitionWindow : Window
    {
        private System.Drawing.Image? lastImageInserted;

        public AddCompetitionWindow()
        {
            InitializeComponent();
            TimingTypeBox.ItemsSource = GlobalConfig.DefaultTimings;
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();

        private void DisplayMessage(string text, bool success)
        {
            MessagePanel.Children.Clear();
            MessagePanel.Children.Add(new System.Windows.Controls.TextBlock
            {
                Text = text,
                Foreground = success ? Brushes.Green : Brushes.IndianRed,
                FontWeight = FontWeights.SemiBold
            });
        }

        private bool ValidateFields()
        {
            MessagePanel.Children.Clear();

            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                DisplayMessage("Name cannot be empty!", false);
                return false;
            }

            if (TimingsButton.IsChecked == true && TimingTypeBox.SelectedIndex < 0)
            {
                DisplayMessage("Please choose a timing format!", false);
                return false;
            }

            if (GlobalData.Competitions.Any(c =>
                c.Name.Trim().Equals(NameBox.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                DisplayMessage("Competition already exists!", false);
                return false;
            }

            return true;
        }

        private void ScoreTypeChanged(object sender, RoutedEventArgs e)
        {
            if (TimingTypeBox == null) return;
            TimingTypeBox.IsEnabled = TimingsButton.IsChecked == true;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields()) return;

            int placementType = PointsButton.IsChecked == true ? 1 : 0;
            int timingType = placementType == 0 ? TimingTypeBox.SelectedIndex : -1;
            int orderingType = DescendingButton.IsChecked == true ? 1 : 0;

            string imagePath = "";
            if (lastImageInserted != null)
                imagePath = GlobalConfig.ImageStorage.Save(lastImageInserted);

            var comp = new CompetitionModel(
                NameBox.Text.Trim(),
                DescriptionBox.Text.Trim(),
                imagePath,
                placementType,
                orderingType,
                timingType
            );

            CRUD.CreateCompetition(comp);

            DisplayMessage("Insert successful!", true);

            GlobalEvents.RaiseCompetitionsChanged();

            // Clear inputs
            NameBox.Text = "";
            DescriptionBox.Text = "";
            CompetitionImagePreview.Source = null;
            lastImageInserted = null;
            ImageInfoText.Text = "Click to paste\nimage from clipboard";
        }

        // IMAGE: Clipboard support
        private void ImageFrame_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                var source = Clipboard.GetImage();
                CompetitionImagePreview.Source = source;
                lastImageInserted = ConvertToBitmap(source);
                ImageInfoText.Text = "";
            }
            else
            {
                MessageBox.Show("No image in clipboard", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private static System.Drawing.Bitmap? ConvertToBitmap(BitmapSource source)
        {
            if (source == null) return null;
            using var ms = new MemoryStream();
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(source));
            encoder.Save(ms);
            ms.Position = 0;
            return new System.Drawing.Bitmap(ms);
        }

        private void Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ImageFrame.Background = Brushes.Silver;
        }

        private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ImageFrame.Background = Brushes.Gray;
        }
    }
}
