using CompLibrary;
using CompLibrary.Storage_Management;
using CompUIWPF.Vehicles;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompUIWPF.Competitions
{
    public partial class CompetitionManager : UserControl
    {
        private CompetitionModel? _currentCompetition;
        private AddCompetitionWindow _addCompetitionWindow = new();
        // Filter state:0 = none,1 = brand,2 = category
        private int FilterType = 0;
        private HashSet<string> FilterResult = [];

        public CompetitionManager()
        {
            InitializeComponent();
            LoadCompetitions();
            ReloadCompetitors();

            // Subscribe to entry updates
            GlobalEvents.CompetitionEntriesChanged += ReloadCompetitors;
            GlobalEvents.CompetitionsChanged += LoadCompetitions;
        }

        ~CompetitionManager()
        {
            GlobalEvents.CompetitionEntriesChanged -= ReloadCompetitors;
            GlobalEvents.CompetitionsChanged -= LoadCompetitions;
        }

        private void LoadCompetitions()
        {
            // ensure competitions are presented in alphabetical order
            var list = GlobalData.Competitions.Select(c => c.Name).OrderBy(x => x).ToList();
            CompetitionSelect.ItemsSource = list;
            if (list.Count > 0)
            {
                CompetitionSelect.SelectedIndex = 0; // will fire SelectionChanged and update UI
            }
        }

        private void CompetitionSelect_Changed(object sender, SelectionChangedEventArgs e)
        {
            if (CompetitionSelect.SelectedItem is string name)
            {
                _currentCompetition = GlobalData.Competitions.FirstOrDefault(c => c.Name == name);
                UpdateCompetitionDetails();
                ReloadCompetitors();
            }
        }

        private void UpdateCompetitionDetails()
        {
            if (_currentCompetition == null)
            {
                DescriptionText.Text = string.Empty;
                ScoreTypeOutput.Text = "<null>";
                SortedTypeOutput.Text = "<null>";
                CompetitionImage.Visibility = Visibility.Collapsed;
                CompetitionImage.Source = null;
                return;
            }

            // Description
            DescriptionText.Text = _currentCompetition.Description ?? string.Empty;

            // Scoring type
            ScoreTypeOutput.Text = _currentCompetition.PlacementType == 1 ? "Points" : "Timings";

            // Ordering type
            SortedTypeOutput.Text = _currentCompetition.OrderingType == 1 ? "Descending" : "Ascending";

            // Image
            if (!string.IsNullOrWhiteSpace(_currentCompetition.ImagePath))
            {
                try
                {
                    var uri = new Uri(_currentCompetition.ImagePath, UriKind.RelativeOrAbsolute);
                    var bmp = new BitmapImage();
                    bmp.BeginInit();
                    bmp.CacheOption = BitmapCacheOption.OnLoad;
                    bmp.UriSource = uri;
                    bmp.EndInit();
                    bmp.Freeze();
                    CompetitionImage.Source = bmp;
                    CompetitionImage.Visibility = Visibility.Visible;
                }
                catch
                {
                    CompetitionImage.Source = null;
                    CompetitionImage.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                CompetitionImage.Source = null;
                CompetitionImage.Visibility = Visibility.Collapsed;
            }
        }

        public void ReloadCompetitors()
        {
            CompetitorsPanel.Children.Clear();
            if (_currentCompetition == null) return;

            bool showPictures = true; // could expose as option
            int currentIndex = 0;
            double lastScore = -1;
            int toIncrement = 1;
            int currentPosition = 0;

            var lightBrush = new SolidColorBrush(Colors.White) { Opacity = 0.04 };
            var darkBrush = new SolidColorBrush(Colors.Black) { Opacity = 0.05 };
            if (lightBrush.CanFreeze) lightBrush.Freeze();
            if (darkBrush.CanFreeze) darkBrush.Freeze();

            // prepare list applying current filters
            IEnumerable<CompetitorModel> competitors = _currentCompetition.Competitors ?? Enumerable.Empty<CompetitorModel>();
            if (FilterType == 1 && FilterResult?.Count > 0)
            {
                competitors = competitors.Where(c =>
                {
                    var v = GlobalData.Vehicles.Values.FirstOrDefault(vv => vv.Id == c.VehicleId);
                    return v != null && FilterResult.Contains(v.Brand);
                });
            }
            else if (FilterType == 2 && FilterResult?.Count > 0)
            {
                competitors = competitors.Where(c =>
                {
                    var v = GlobalData.Vehicles.Values.FirstOrDefault(vv => vv.Id == c.VehicleId);
                    return v != null && FilterResult.Contains(v.Category);
                });
            }

            foreach (var competitor in competitors)
            {
                currentIndex++;
                if (competitor.Score != lastScore)
                {
                    currentPosition += toIncrement;
                    lastScore = competitor.Score;
                    toIncrement = 1;
                }
                else toIncrement++;

                var row = new Border
                {
                    Background = (currentIndex % 2 == 0) ? lightBrush : darkBrush,
                    Padding = new Thickness(6, 1, 6, 1),
                    Margin = new Thickness(0, 0, 0, 6),
                    CornerRadius = new CornerRadius(4)
                };

                var grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60) }); // Pos
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = showPictures ? GridLength.Auto : new GridLength(0) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(120) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(180) });

                // Position + medal
                // Position + medal
                var posStack = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };

                // Medal for top 3
                if (currentPosition <= 3)
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
                            3 => Brushes.SandyBrown, // bronze-ish
                            _ => Brushes.Transparent
                        }
                    };
                    posStack.Children.Add(medalIcon);
                }

                // Position number
                posStack.Children.Add(new TextBlock
                {
                    Text = currentPosition.ToString(),
                    VerticalAlignment = VerticalAlignment.Center,
                    FontWeight = FontWeights.SemiBold
                });

                Grid.SetColumn(posStack, 0);
                grid.Children.Add(posStack);

                // Brand
                var vehicle = GlobalData.Vehicles.Values.FirstOrDefault(v => v.Id == competitor.VehicleId);
                var brand = new TextBlock { Text = vehicle?.Brand ?? "-", VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(brand, 2);
                grid.Children.Add(brand);

                // Model
                var model = new TextBlock { Text = vehicle?.Model ?? "-", VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(model, 3);
                grid.Children.Add(model);

                // Category
                var category = new TextBlock { Text = vehicle?.Category ?? "-", VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(category, 4);
                grid.Children.Add(category);

                // Score
                string scoreText;
                HorizontalAlignment scoreAlignment = HorizontalAlignment.Center;
                if (_currentCompetition.PlacementType == 1)
                {
                    scoreText = competitor.Score.ToString();
                    scoreAlignment = HorizontalAlignment.Center;
                }
                else
                {
                    scoreText = FunctionLibrary.GetTimeString(competitor.Score, _currentCompetition.TimingType);
                    scoreAlignment = HorizontalAlignment.Left;
                }

                var score = new TextBlock { Text = scoreText, HorizontalAlignment = scoreAlignment, VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(score, 5);
                grid.Children.Add(score);

                // Actions
                var actions = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Right };
                static Button CreateIconButton(PackIconMaterialKind kind, string tooltip, int tag)
                {
                    var icon = new PackIconMaterial { Kind = kind, Width = 18, Height = 18, VerticalAlignment = VerticalAlignment.Center };
                    var btn = new Button { Content = icon, Width = 40, Height = 32, Margin = new Thickness(4, 0, 0, 0), Tag = tag, ToolTip = tooltip };
                    return btn;
                }

                var edit = CreateIconButton(PackIconMaterialKind.Pencil, "Edit entry", competitor.Id);
                edit.Click += EditEntry_Click;
                var del = CreateIconButton(PackIconMaterialKind.Delete, "Delete entry", competitor.Id);
                del.Click += DeleteEntry_Click;
                actions.Children.Add(edit);
                actions.Children.Add(del);

                Grid.SetColumn(actions, 6);
                grid.Children.Add(actions);

                row.Child = grid;
                CompetitorsPanel.Children.Add(row);
            }

        }

        private void EditEntry_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b && b.Tag is int id)
            {
                var entry = _currentCompetition!.Competitors.First(x => x.Id == id);
                var win = new EntryUpdateWindow(_currentCompetition.Id, entry)
                {
                    Owner = Window.GetWindow(this),
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

        private void DeleteEntry_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b && b.Tag is int id)
            {
                var dr = MessageBox.Show("Confirm delete entry?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (dr == MessageBoxResult.Yes)
                {
                    CRUD.DeleteCompetitor(_currentCompetition!.Id, id);
                    GlobalEvents.RaiseCompetitionEntriesChanged();
                }
            }
        }

        private void AddCompetitionButton_Click(object sender, RoutedEventArgs e)
        {
            _addCompetitionWindow = new AddCompetitionWindow
            {
                ShowInTaskbar = true,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            var parent = Window.GetWindow(this);
            parent.IsEnabled = false; // block parent

            // Prevent parent from closing while child is open
            void closingHandler(object? s, CancelEventArgs args)
            {
                if (_addCompetitionWindow != null && _addCompetitionWindow.IsVisible)
                {
                    args.Cancel = true; // block the close
                    _addCompetitionWindow.Activate(); // bring child forward
                }
            }
            parent.Closing += closingHandler;

            _addCompetitionWindow.Closed += (s, args) =>
            {
                parent.IsEnabled = true; // re-enable parent
                parent.Activate();       // bring parent back to front
                parent.Closing -= closingHandler; // remove handler
            };

            _addCompetitionWindow.Show();
        }

        private void AddEntryButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCompetition != null)
            {
                var win = new EntryAddWindow(_currentCompetition.Id) { Owner = Window.GetWindow(this), WindowStartupLocation = WindowStartupLocation.CenterOwner };

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

        private void DeleteCompetition_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCompetition != null)
            {
                var dr = MessageBox.Show("Delete competition and its entries?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (dr == MessageBoxResult.Yes)
                {
                    CRUD.DeleteCompetition(_currentCompetition.Id);
                    LoadCompetitions();
                }
            }
        }

        private void FilterByBrand_Click(object sender, RoutedEventArgs e)
        {
            var choices = GlobalData.Vehicles.Values.Select(v => v.Brand).Distinct().OrderBy(x => x).ToList();
            var win = new Common.FilterWindow(choices, "Brand filter") { Owner = Window.GetWindow(this) };
            if (win.ShowDialog() == true)
            {
                var set = new HashSet<string>(win.Result);
                // persist and apply
                FilterResult = set;
                FilterType = 1;
                ReloadCompetitors();
            }
        }

        private void FilterByCategory_Click(object sender, RoutedEventArgs e)
        {
            var choices = GlobalData.Vehicles.Values.Select(v => v.Category).Distinct().OrderBy(x => x).ToList();
            var win = new Common.FilterWindow(choices, "Category filter") { Owner = Window.GetWindow(this) };
            if (win.ShowDialog() == true)
            {
                var set = new HashSet<string>(win.Result);
                FilterResult = set;
                FilterType = 2;
                ReloadCompetitors();
            }
        }

        private void ClearFilters_Click(object sender, RoutedEventArgs e)
        {
            FilterType = 0;
            FilterResult.Clear();
            ReloadCompetitors();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            LoadCompetitions();
            ReloadCompetitors();
        }
    }
}
