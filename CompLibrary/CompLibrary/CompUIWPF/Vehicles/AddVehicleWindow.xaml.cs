using CompLibrary;
using CompLibrary.Storage_Management;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CompUIWPF.Vehicles
{
    public partial class AddVehicleWindow : Window
    {
        private System.Drawing.Image lastImageInserted;

        public AddVehicleWindow()
        {
            InitializeComponent();
            CategoryComboBox.ItemsSource = GlobalData.Categories;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowMessage(string text, bool success)
        {
            MessagePanel.Children.Clear();
            var tb = new System.Windows.Controls.TextBlock
            {
                Text = text,
                Foreground = success ? new SolidColorBrush(System.Windows.Media.Colors.Green) : new SolidColorBrush(System.Windows.Media.Colors.IndianRed),
                FontWeight = FontWeights.SemiBold,
                Margin = new Thickness(0, 4, 0, 0)
            };
            MessagePanel.Children.Add(tb);
        }

        private bool ValidateFields()
        {
            MessagePanel.Children.Clear();
            if (string.IsNullOrWhiteSpace(BrandTextBox.Text))
            {
                ShowMessage("Brand can not be empty!", false);
                return false;
            }
            if (string.IsNullOrWhiteSpace(ModelTextBox.Text))
            {
                ShowMessage("Model can not be empty!", false);
                return false;
            }
            if (string.IsNullOrWhiteSpace(CategoryComboBox.Text))
            {
                ShowMessage("Category can not be empty!", false);
                return false;
            }

            var exists = GlobalData.Vehicles.Any(v =>
                string.Equals(v.Brand.Trim(), BrandTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase)
                && string.Equals(v.Model.Trim(), ModelTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                ShowMessage("Vehicle already exists!", false);
                return false;
            }

            return true;
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateFields()) return;

            string imagePath = "";
            if (lastImageInserted != null)
            {
                imagePath = GlobalConfig.ImageStorage.Save(lastImageInserted);
            }

            var newVehicle = new VehicleModel(
                BrandTextBox.Text.Trim(),
                ModelTextBox.Text.Trim(),
                CategoryComboBox.Text.Trim(),
                imagePath
                );

            // Create category if needed
            bool categoryAdded = CRUD.CreateCategory(CategoryComboBox.Text.Trim());
            if (categoryAdded)
                ShowMessage("Category created!", true);

            CRUD.CreateVehicle(newVehicle);
            ShowMessage("Insert successful!", true);

            // Raise event so WPF views refresh
            GlobalEvents.RaiseVehiclesChanged();

            // Clear fields
            BrandTextBox.Text = "";
            ModelTextBox.Text = "";
            CategoryComboBox.Text = "";
            VehicleImagePreview.Source = null;
            lastImageInserted = null;
            ImageInfoText.Text = "Click to paste\nimage from clipboard";
        }

        private void RemoveCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            MessagePanel.Children.Clear();
            if (string.IsNullOrWhiteSpace(CategoryComboBox.Text))
            {
                ShowMessage("Cannot delete empty category!", false);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this category?\nNote: This will not remove it from existing vehicles.", "Category deletion", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                bool wasDeleted = CRUD.DeleteCategory(CategoryComboBox.Text);
                if (wasDeleted)
                    ShowMessage("Category deleted!", true);
                else
                    ShowMessage("Category does not exist!", false);
                CategoryComboBox.ItemsSource = null;
                CategoryComboBox.ItemsSource = GlobalData.Categories;
            }
        }

        private void ImageFrame_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                var bmpSource = Clipboard.GetImage();
                VehicleImagePreview.Source = bmpSource;
                ImageInfoText.Text = "";
                lastImageInserted = BitmapFromBitmapSource(bmpSource);
            }
            else
            {
                MessageBox.Show("No image in clipboard", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private static System.Drawing.Bitmap BitmapFromBitmapSource(BitmapSource source)
        {
            if (source == null) return null!;
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(source));
            using (var ms = new MemoryStream())
            {
                encoder.Save(ms);
                ms.Position = 0;
                return new System.Drawing.Bitmap(ms);
            }
        }

        private void Image_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ImageFrame.Background = new SolidColorBrush(System.Windows.Media.Colors.Silver);
        }

        private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ImageFrame.Background = System.Windows.Media.Brushes.Gray;
        }
    }
}