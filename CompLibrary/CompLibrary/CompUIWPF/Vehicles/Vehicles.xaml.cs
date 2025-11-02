using CompLibrary;
using CompLibrary.Storage_Management;
using CompUIWPF.Common;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CompUIWPF.Vehicles
{
    public partial class Vehicles : UserControl
    {
        private int SortType = 1; // 1 = name, 2 = avg position
        private int FilterType = 0; // 0 = none, 1 = brand, 2 = category
        private HashSet<string> FilterResult = [];
        private AddVehicleWindow _addWindow = new();
        private UpdateVehicleWindow _updateWindow = new();

        public Vehicles()
        {
            InitializeComponent();
            ShowPicturesCheck.IsChecked = false;

            // subscribe when control is loaded, unsubscribe when unloaded
            Loaded += Vehicles_Loaded;
            Unloaded += Vehicles_Unloaded;

            ReloadVehiclePanels();
        }

        private void Vehicles_Loaded(object sender, RoutedEventArgs e)
        {
            GlobalEvents.VehiclesChanged += OnVehiclesChanged;
        }

        private void Vehicles_Unloaded(object sender, RoutedEventArgs e)
        {
            GlobalEvents.VehiclesChanged -= OnVehiclesChanged;
        }

        private void OnVehiclesChanged()
        {
            // ensure run on UI thread
            Dispatcher.Invoke(() => ReloadVehiclePanels());
        }

        public void ReloadVehiclePanels()
        {
            LoadVehiclePanel(SortType, FilterType);
        }

        private void LoadVehiclePanel(int sortType, int filterType = 0)
        {
            var vehicles = GlobalData.Vehicles.Values.ToList();
            List<VehicleModel> filteredVehicles;
            VehiclesPanel.Children.Clear();

            // Apply filter if any
            if (filterType == 1 || filterType == 2)
            {
                filteredVehicles = [.. vehicles.Where(v =>
                    FilterResult.Contains(filterType == 1 ? v.Brand : v.Category))];
                vehicles = filteredVehicles;
            }

            // Apply sort
            if (sortType == 1)
            {
                vehicles = [.. vehicles.OrderBy(x => x.Brand).ThenBy(x => x.Model)];
            }
            else
            {
                vehicles = [.. vehicles.OrderBy(x => x.AveragePosition())];
            }

            bool showPictures = ShowPicturesCheck.IsChecked == true;
            int currentIndex = 0;
            double lastScore = -1;
            int toIncrement = 1;
            int currentPosition = 0;

            // Use white/black overlays with low opacity so rows are slightly lighter/darker than background.
            var lightBrush = new SolidColorBrush(Colors.White) { Opacity = 0.04 };
            var darkBrush = new SolidColorBrush(Colors.Black) { Opacity = 0.05 };
            // Freeze brushes for a minor performance benefit
            if (lightBrush.CanFreeze) lightBrush.Freeze();
            if (darkBrush.CanFreeze) darkBrush.Freeze();

            foreach (var vehicle in vehicles)
            {
                currentIndex++;

                if (vehicle.AveragePosition() != lastScore)
                {
                    currentPosition += toIncrement;
                    lastScore = vehicle.AveragePosition();
                    toIncrement = 1;
                }
                else
                {
                    toIncrement++;
                }

                // row container: alternate using white/black overlay brushes
                var rowBorder = new Border
                {
                    Background = (currentIndex % 2 == 0) ? lightBrush : darkBrush,
                    Padding = new Thickness(6, 1, 6, 1),
                    Margin = new Thickness(0, 0, 0, 6),
                    CornerRadius = new CornerRadius(4)
                };

                var grid = new Grid();
                // Always create the same column layout; picture column can be0 width when hidden
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60) }); // pos (0)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = showPictures ? GridLength.Auto : new GridLength(0) }); // picture (1)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) }); // brand (2)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) }); // model (3)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) }); // category (4)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(120) }); // avg pos (5)
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(180) }); // actions (6)

                // Position + medal (only for average position sort)
                var posStack = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };

                int displayPosition = (sortType == 2) ? currentPosition : currentIndex;

                // Add medal for top 3 when sorting by average position
                if (sortType == 2 && currentPosition <= 3)
                {
                    PackIconMaterial medalIcon = new()
                    {
                        Kind = PackIconMaterialKind.Medal,
                        Width = 16,
                        Height = 16,
                        Margin = new Thickness(0, 0, 4, 0),
                        VerticalAlignment = VerticalAlignment.Center,
                        Foreground = currentPosition switch
                        {
                            1 => Brushes.Gold,
                            2 => Brushes.Silver,
                            3 => Brushes.SandyBrown, // bronze
                            _ => Brushes.Transparent
                        }
                    };
                    posStack.Children.Add(medalIcon);
                }

                // Add position number
                posStack.Children.Add(new TextBlock
                {
                    Text = displayPosition.ToString(),
                    VerticalAlignment = VerticalAlignment.Center,
                    FontWeight = FontWeights.SemiBold
                });

                Grid.SetColumn(posStack, 0);
                grid.Children.Add(posStack);

                // Picture (only add image control when showing pictures)
                if (showPictures)
                {
                    var border = new Border
                    {
                        Width = 60,
                        Height = 60,
                        Background = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0)), // 25/255 ≈ 0.1 opacity
                        Margin = new Thickness(6, 0, 6, 0),
                        CornerRadius = new CornerRadius(4) // optional rounding
                    };

                    var img = new Image
                    {
                        Stretch = Stretch.Uniform
                    };

                    if (!string.IsNullOrEmpty(vehicle.ImagePath))
                    {
                        try
                        {
                            var bmp = new BitmapImage();
                            bmp.BeginInit();
                            bmp.CacheOption = BitmapCacheOption.OnLoad;
                            bmp.UriSource = new Uri(vehicle.ImagePath, UriKind.RelativeOrAbsolute);
                            bmp.EndInit();
                            img.Source = bmp;
                        }
                        catch
                        {
                            // ignore, leave empty
                        }
                    }

                    border.Child = img;
                    Grid.SetColumn(border, 1);
                    grid.Children.Add(border);
                }

                // Brand (always column2)
                var brandText = new TextBlock { Text = vehicle.Brand, VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(brandText, 2);
                grid.Children.Add(brandText);

                // Model (always column3)
                var modelText = new TextBlock { Text = vehicle.Model, VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(modelText, 3);
                grid.Children.Add(modelText);

                // Category (always column4)
                var categoryText = new TextBlock { Text = vehicle.Category, VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(categoryText, 4);
                grid.Children.Add(categoryText);

                // Avg pos (always column5)
                var avgText = new TextBlock
                {
                    Text = vehicle.AveragePosition() < 1000000 ? Math.Round(vehicle.AveragePosition(), 2).ToString() : "None",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                Grid.SetColumn(avgText, 5);
                grid.Children.Add(avgText);

                // Actions (Edit / Delete) — create icon-only buttons styled consistently
                var actionsPanel = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Right };

                // Helper to create an icon-only button
                static Button CreateIconButton(PackIconMaterialKind kind, string toolTip, int tag)
                {
                    var icon = new PackIconMaterial
                    {
                        Kind = kind,
                        Width = 18,
                        Height = 18,
                        VerticalAlignment = VerticalAlignment.Center,
                        // Foreground will inherit from Button foreground, which in turn follows theme
                    };
                    var btn = new Button
                    {
                        Content = icon,
                        Width = 40,
                        Height = 32,
                        Margin = new Thickness(4, 0, 0, 0),
                        Tag = tag,
                        ToolTip = toolTip,
                        Padding = new Thickness(0),
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center
                    };
                    return btn;
                }

                var editButton = CreateIconButton(PackIconMaterialKind.Pencil, "Edit", vehicle.Id);
                editButton.Click += EditButton_Click;
                var deleteButton = CreateIconButton(PackIconMaterialKind.Delete, "Delete", vehicle.Id);
                deleteButton.Click += DeleteButton_Click;

                actionsPanel.Children.Add(editButton);
                actionsPanel.Children.Add(deleteButton);

                Grid.SetColumn(actionsPanel, 6);
                grid.Children.Add(actionsPanel);

                rowBorder.Child = grid;
                VehiclesPanel.Children.Add(rowBorder);
            }
        }

        // Event handlers

        private void ShowPicturesCheck_Changed(object sender, RoutedEventArgs e)
        {
            ReloadVehiclePanels();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _addWindow = new AddVehicleWindow
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

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            _updateWindow = new UpdateVehicleWindow
            {
                ShowInTaskbar = true, // ensures it appears in the taskbar
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            var parent = Window.GetWindow(this);
            parent.IsEnabled = false; // block parent

            // Prevent parent from closing while child is open
            void closingHandler(object? s, CancelEventArgs args)
            {
                if (_updateWindow != null && _updateWindow.IsVisible)
                {
                    args.Cancel = true; // block the close
                    _updateWindow.Activate(); // bring child forward
                }
            }
            parent.Closing += closingHandler;

            _updateWindow.Closed += (s, args) =>
            {
                parent.IsEnabled = true; // re-enable parent
                parent.Activate();       // bring parent back to front
                parent.Closing -= closingHandler; // remove handler
            };

            _updateWindow.Show();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b && b.Tag is int id)
            {
                // open update window for the selected vehicle id
                var win = new UpdateVehicleWindow(id)
                {
                    ShowInTaskbar = true, // ensures it appears in the taskbar
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };

                var parent = Window.GetWindow(this);
                parent.IsEnabled = false; // block parent

                // Prevent parent from closing while child is open
                void closingHandler(object? s, CancelEventArgs args)
                {
                    if (win != null && win.IsVisible)
                    {
                        args.Cancel = true; // block the close
                        win.Activate(); // bring child forward
                    }
                }
                parent.Closing += closingHandler;

                win.Closed += (s, args) =>
                {
                    parent.IsEnabled = true; // re-enable parent
                    parent.Activate();       // bring parent back to front
                    parent.Closing -= closingHandler; // remove handler
                };

                win.Show();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b && b.Tag is int id)
            {
                var dr = MessageBox.Show("Are you sure you want to delete this vehicle?\nThis action is permanent and will remove it from all competitions!", "Please confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (dr == MessageBoxResult.Yes)
                {
                    bool vehicleDeleted = CRUD.DeleteVehicle(id);
                    if (!vehicleDeleted)
                    {
                        MessageBox.Show("This vehicle does not exist!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        ReloadVehiclePanels();
                        GlobalEvents.RaiseVehiclesChanged();
                    }
                }
            }
        }

        // Menu handlers
        private void SortByAverage_Click(object sender, RoutedEventArgs e)
        {
            SortType = 2;
            ReloadVehiclePanels();
        }

        private void SortByName_Click(object sender, RoutedEventArgs e)
        {
            SortType = 1;
            ReloadVehiclePanels();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ShowPicturesCheck.IsChecked = false;
            SortType = 1;
            FilterType = 0;
            FilterResult.Clear();
            ReloadVehiclePanels();
        }

        private void FilterByBrand_Click(object sender, RoutedEventArgs e)
        {
            var choices = GlobalData.Vehicles.Values.Select(v => v.Brand).Distinct().OrderBy(x => x).ToList();
            var win = new FilterWindow(choices, "Brand filter")
            {
                Owner = Window.GetWindow(this)
            };
            if (win.ShowDialog() == true)
            {
                FilterResult = [.. win.Result];
                FilterType = 1;
                ReloadVehiclePanels();
            }
        }

        private void FilterByCategory_Click(object sender, RoutedEventArgs e)
        {
            var choices = GlobalData.Vehicles.Values.Select(v => v.Category).Distinct().OrderBy(x => x).ToList();
            var win = new FilterWindow(choices, "Category filter")
            {
                Owner = Window.GetWindow(this)
            };
            if (win.ShowDialog() == true)
            {
                FilterResult = [.. win.Result];
                FilterType = 2;
                ReloadVehiclePanels();
            }
        }

        private void ClearFilters_Click(object sender, RoutedEventArgs e)
        {
            FilterType = 0;
            FilterResult.Clear();
            ReloadVehiclePanels();
        }

        private void AboutMenu_Click(object sender, RoutedEventArgs e)
        {
            var about = new Common.About();
            var win = new Window
            {
                Title = "About",
                Content = about,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = Window.GetWindow(this),
                ResizeMode = ResizeMode.NoResize,
                Style = (Style)FindResource("MaterialDesignWindow")
            };
            win.ShowDialog();
        }
    }
}
