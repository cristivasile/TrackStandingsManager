using CompLibrary;
using CompLibrary.Storage_Management;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CompUIWPF.Vehicles
{
    public partial class UpdateVehicleWindow : Window
    {
        private VehicleModel StoredVehicle;
        private bool ImageChanged = false;
        private readonly Dictionary<string, int> VehicleIds = new();

        public UpdateVehicleWindow()
        {
            InitializeComponent();
            InitializeVehicleIds();
            CategoryComboBox.ItemsSource = GlobalData.Categories;
            VehicleComboBox.ItemsSource = VehicleIds.Keys.OrderBy(x => x).ToList();
        }

        // New constructor that accepts a vehicle id and loads it immediately
        public UpdateVehicleWindow(int vehicleId) : this()
        {
            var vehicle = CRUD.GetVehicleById(vehicleId);
            if (vehicle != null)
            {
                LoadVehicle(vehicle);
            }
        }

        private void InitializeVehicleIds()
        {
            VehicleIds.Clear();
            foreach (var v in GlobalData.Vehicles)
            {
                VehicleIds[v.Brand + " " + v.Model] = v.Id;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoadVehicle(VehicleModel vehicle)
        {
            ImageChanged = false;
            MessagePanel.Children.Clear();

            if (vehicle != null)
            {
                StoredVehicle = vehicle;
                VehicleComboBox.Text = vehicle.Brand + " " + vehicle.Model;
                BrandTextBox.Text = vehicle.Brand;
                ModelTextBox.Text = vehicle.Model;
                CategoryComboBox.Text = vehicle.Category;
                if (!string.IsNullOrEmpty(vehicle.ImagePath) && File.Exists(vehicle.ImagePath))
                {
                    try
                    {
                        var bmp = new BitmapImage();
                        bmp.BeginInit();
                        bmp.CacheOption = BitmapCacheOption.OnLoad;
                        bmp.UriSource = new Uri(vehicle.ImagePath, UriKind.RelativeOrAbsolute);
                        bmp.EndInit();
                        VehicleImagePreview.Source = bmp;
                        ImageInfoText.Visibility = Visibility.Collapsed;
                    }
                    catch
                    {
                        VehicleImagePreview.Source = null;
                        ImageInfoText.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    VehicleImagePreview.Source = null;
                    ImageInfoText.Visibility = Visibility.Visible;
                }
            }
            else
            {
                StoredVehicle = null;
                VehicleComboBox.Text = "";
                BrandTextBox.Text = "";
                ModelTextBox.Text = "";
                CategoryComboBox.Text = "";
                VehicleImagePreview.Source = null;
                ImageInfoText.Visibility = Visibility.Visible;
            }
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessagePanel.Children.Clear();
            if (StoredVehicle == null)
            {
                ShowMessage("No vehicle to update!", false);
                return;
            }

            var updated = new VehicleModel(StoredVehicle);
            string filePath = StoredVehicle.ImagePath;

            if (ImageChanged)
            {
                try
                {
                    if (!string.IsNullOrEmpty(StoredVehicle.ImagePath) && File.Exists(StoredVehicle.ImagePath))
                        File.Delete(StoredVehicle.ImagePath);
                }
                catch { /* ignore */ }

                if (VehicleImagePreview.Source is BitmapSource bs)
                {
                    var bmp = BitmapFromBitmapSource(bs);
                    filePath = GlobalConfig.ImageStorage.Save(bmp);
                }
            }

            updated.Brand = BrandTextBox.Text.Trim();
            updated.Model = ModelTextBox.Text.Trim();
            updated.Category = CategoryComboBox.Text.Trim();
            updated.ImagePath = filePath;

            bool changed = VehicleChanged(updated);
            if (!changed)
            {
                ShowMessage("Vehicle has not changed!", false);
                return;
            }

            // Validate
            if (string.IsNullOrEmpty(updated.Brand) || string.IsNullOrEmpty(updated.Model) || string.IsNullOrEmpty(updated.Category))
            {
                ShowMessage("Brand/Model/Category cannot be empty!", false);
                return;
            }

            // ensure uniqueness if brand or model changed
            if (!string.Equals(updated.Brand, StoredVehicle.Brand, StringComparison.OrdinalIgnoreCase) ||
                !string.Equals(updated.Model, StoredVehicle.Model, StringComparison.OrdinalIgnoreCase))
            {
                foreach (var v in GlobalData.Vehicles)
                {
                    if (v.Id != StoredVehicle.Id &&
                        string.Equals(v.Brand + v.Model, updated.Brand + updated.Model, StringComparison.OrdinalIgnoreCase))
                    {
                        ShowMessage("Vehicle already exists!", false);
                        return;
                    }
                }
            }

            // apply update
            CRUD.UpdateVehicle(updated);
            StoredVehicle = updated;
            InitializeVehicleIds();
            VehicleComboBox.ItemsSource = VehicleIds.Keys.OrderBy(x => x).ToList();
            ShowMessage("Vehicle successfully updated!", true);

            // Raise event so views refresh
            GlobalEvents.RaiseVehiclesChanged();
        }

        private bool VehicleChanged(VehicleModel updated)
        {
            if (StoredVehicle == null) return true;
            if (updated.Brand != StoredVehicle.Brand ||
                updated.Model != StoredVehicle.Model ||
                updated.Category != StoredVehicle.Category ||
                updated.ImagePath != StoredVehicle.ImagePath ||
                ImageChanged)
                return true;
            return false;
        }

        private void ImageFrame_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                var bmpSource = Clipboard.GetImage();
                VehicleImagePreview.Source = bmpSource;
                ImageInfoText.Visibility = Visibility.Collapsed;
                ImageChanged = true;
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

        private void DeleteVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            MessagePanel.Children.Clear();
            if (StoredVehicle == null)
            {
                ShowMessage("No vehicle to delete!", false);
                return;
            }

            var res = MessageBox.Show("Are you sure you want to delete this vehicle?\nThis action is permanent and will remove it from all competitions!", "Are you sure", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                bool deleted = CRUD.DeleteVehicle(StoredVehicle.Id);
                if (!deleted)
                {
                    ShowMessage("Vehicle does not exist!", false);
                }
                else
                {
                    InitializeVehicleIds();
                    VehicleComboBox.ItemsSource = VehicleIds.Keys.OrderBy(x => x).ToList();
                    LoadVehicle(null);
                    ShowMessage("Vehicle deleted!", true);

                    // Raise event so views refresh
                    GlobalEvents.RaiseVehiclesChanged();
                }
            }
        }

        private void UndoChangesButton_Click(object sender, RoutedEventArgs e)
        {
            MessagePanel.Children.Clear();
            if (StoredVehicle != null)
            {
                LoadVehicle(CRUD.GetVehicleById(StoredVehicle.Id));
                ShowMessage("Changes successfully undone!", true);
            }
            else
                ShowMessage("No vehicle to reset!", false);
        }

        private void VehicleComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (VehicleComboBox.SelectedItem is string text && VehicleIds.TryGetValue(text, out int id))
            {
                var vehicle = CRUD.GetVehicleById(id);
                LoadVehicle(vehicle);
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var search = VehicleComboBox.Text?.Trim();
            foreach (var kv in VehicleIds)
            {
                if (string.Equals(kv.Key, search, StringComparison.OrdinalIgnoreCase))
                {
                    var vehicle = CRUD.GetVehicleById(kv.Value);
                    LoadVehicle(vehicle);
                    return;
                }
            }
            ShowMessage("Vehicle not found!", false);
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