using CompLibrary;
using CompLibrary.Storage_Management;
using CompUIWPF.Vehicles;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;

namespace CompUIWPF.Competitions
{
    public partial class CompetitionManager : UserControl
    {
        private CompetitionModel? _currentCompetition;
        private List<CompetitorModel> _viewCompetitors = [];
        // Filter state:0 = none,1 = brand,2 = category
        private int FilterType = 0;
        private HashSet<string> FilterResult = [];

        private enum SortType { Default, DateAsc, DateDesc }
        private SortType _currentSort = SortType.Default;

        public CompetitionManager()
        {
            InitializeComponent();
            LoadCompetitions();

            // Ensure view list is built from currently selected competition (if any)
            if (CompetitionSelect.SelectedItem is string selected)
            {
                _currentCompetition = GlobalData.Competitions.FirstOrDefault(c => c.Name == selected);
            }
            RefreshView();

            // Subscribe to entry updates
            GlobalEvents.CompetitionEntriesChanged += OnCompetitionEntriesChanged;
            GlobalEvents.CompetitionsChanged += OnCompetitionsChanged;
        }

        ~CompetitionManager()
        {
            GlobalEvents.CompetitionEntriesChanged -= OnCompetitionEntriesChanged;
            GlobalEvents.CompetitionsChanged -= OnCompetitionsChanged;
        }

        private void OnCompetitionEntriesChanged()
        {
            RefreshView();
        }

        private void OnCompetitionsChanged()
        {
            // competitions list changed — reload selector and rebuild view
            LoadCompetitions();
            // Keep current selection if possible
            if (_currentCompetition != null)
            {
                var found = GlobalData.Competitions.FirstOrDefault(c => c.Id == _currentCompetition.Id);
                if (found == null)
                {
                    _currentCompetition = null;
                    _viewCompetitors.Clear();
                }
                else
                {
                    _currentCompetition = found;
                }
            }
            RefreshView();
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

                RefreshView();
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

        private void RefreshView()
        {
            // Start from original list
            if (_currentCompetition == null) return;
            _viewCompetitors = [.. _currentCompetition.Competitors.Select(c => c.Clone())];

            // Apply ordering if any
            switch (_currentSort)
            {
                case SortType.DateAsc:
                    _viewCompetitors = [.. _viewCompetitors.OrderBy(c => c.Timestamp)];
                    break;
                case SortType.DateDesc:
                    _viewCompetitors = [.. _viewCompetitors.OrderByDescending(c => c.Timestamp)];
                    break;
                case SortType.Default:
                default:
                    break; // keep original order
            }

            // Apply filters if any
            if (FilterType == 1 && FilterResult?.Count > 0)
                _viewCompetitors = [.. _viewCompetitors.Where(c =>
                {
                    var v = GlobalData.Vehicles.Values.FirstOrDefault(vv => vv.Id == c.VehicleId);
                    return v != null && FilterResult.Contains(v.Brand);
                })];
            else if (FilterType == 2 && FilterResult?.Count > 0)
                _viewCompetitors = [.. _viewCompetitors.Where(c =>
                {
                    var v = GlobalData.Vehicles.Values.FirstOrDefault(vv => vv.Id == c.VehicleId);
                    return v != null && FilterResult.Contains(v.Category);
                })];

            // Update UI display of current sort
            CurrentSortOutput.Text = _currentSort switch
            {
                SortType.Default => "Default",
                SortType.DateAsc => "Date Asc",
                SortType.DateDesc => "Date Desc",
                _ => "Unknown"
            };

            ReloadCompetitors();
        }


        public void ReloadCompetitors()
        {
            CompetitorsPanel.Children.Clear();
            if (_currentCompetition == null) return;

            // ALWAYS use the view list (deep copy) as the source of truth for UI rendering.
            IEnumerable<CompetitorModel> competitors = _viewCompetitors;

            int currentIndex = 0;
            double lastScore = -1;
            DateTime lastDate = DateTime.MinValue;
            int toIncrement = 1;
            int currentPosition = 0;

            var lightBrush = new SolidColorBrush(Colors.White) { Opacity = 0.04 };
            var darkBrush = new SolidColorBrush(Colors.Black) { Opacity = 0.05 };
            if (lightBrush.CanFreeze) lightBrush.Freeze();
            if (darkBrush.CanFreeze) darkBrush.Freeze();

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

                // Position calculation
                if (_currentSort == SortType.Default)
                {
                    if (competitor.Score != lastScore)
                    {
                        currentPosition += toIncrement;
                        lastScore = competitor.Score;
                        toIncrement = 1;
                    }
                    else
                    {
                        toIncrement++;
                    }
                }
                else
                {
                    if (competitor.Timestamp.Day != lastDate.Day || competitor.Timestamp.Month != lastDate.Month || competitor.Timestamp.Year != lastDate.Year)
                    {
                        currentPosition += 1;
                        lastDate = competitor.Timestamp;
                    }
                }

                // Determine base alternating color
                var baseBrush = (currentIndex % 2 == 0) ? lightBrush : darkBrush;

                // Apply medal tint if in top 3, only for default sorting
                if (_currentSort == SortType.Default && currentPosition <= 3)
                {
                    Color medalColor = currentPosition switch
                    {
                        1 => Colors.Gold,
                        2 => Colors.Silver,
                        3 => Colors.SandyBrown,
                        _ => Colors.Transparent
                    };

                    // Blend with low opacity so it's subtle
                    baseBrush = new SolidColorBrush(Color.FromArgb(40, medalColor.R, medalColor.G, medalColor.B));
                    if (baseBrush.CanFreeze) baseBrush.Freeze();
                }

                var row = new Border
                {
                    Background = baseBrush,
                    Padding = new Thickness(6, 1, 6, 1),
                    Margin = new Thickness(0, 0, 0, 6),
                    CornerRadius = new CornerRadius(4)
                };

                var grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(60) }); // Pos
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(430) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(430) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(160) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(120) }); // Timestamp
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(120) }); // Score
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(180) }); // Actions

                // Position + medal
                var posStack = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };

                // Medal for top 3
                if (_currentSort == SortType.Default && currentPosition <= 3)
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
                Grid.SetColumn(brand, 1);
                grid.Children.Add(brand);

                // Model
                var model = new TextBlock { Text = vehicle?.Model ?? "-", VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(model, 2);
                grid.Children.Add(model);

                // Category
                var category = new TextBlock { Text = vehicle?.Category ?? "-", VerticalAlignment = VerticalAlignment.Center };
                Grid.SetColumn(category, 3);
                grid.Children.Add(category);

                // Timestamp
                var timestampBlock = new TextBlock
                {
                    Text = competitor.Timestamp.ToString("dd-MMM-yy", new CultureInfo("en-US")), // e.g., 11-Nov-25
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
                Grid.SetColumn(timestampBlock, 4);
                grid.Children.Add(timestampBlock);

                // Score / DNF
                string scoreText;
                if (_currentCompetition.PlacementType == 1)
                {
                    scoreText = competitor.Score.ToString();
                }
                else
                {
                    scoreText = FunctionLibrary.GetTimeString(competitor.Score);
                }

                var scoreBlock = new TextBlock
                {
                    Text = scoreText,
                    HorizontalAlignment = HorizontalAlignment.Right,
                    VerticalAlignment = VerticalAlignment.Center
                };

                // If infinity, set DNF and color red
                if (double.IsInfinity(competitor.Score))
                {
                    scoreBlock.Text = "DNF";
                    scoreBlock.Foreground = new SolidColorBrush(Colors.IndianRed);
                }

                Grid.SetColumn(scoreBlock, 5);
                grid.Children.Add(scoreBlock);

                // Actions
                var actions = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Right };
                static Button CreateIconButton(PackIconMaterialKind kind, string tooltip, int tag)
                {
                    var icon = new PackIconMaterial { Kind = kind, Width = 18, Height = 18, VerticalAlignment = VerticalAlignment.Center };
                    var btn = new Button { Content = icon, Width = 40, Height = 32, Margin = new Thickness(4, 0, 0, 0), Padding = new Thickness(0), Tag = tag, ToolTip = tooltip };
                    return btn;
                }

                var edit = CreateIconButton(PackIconMaterialKind.Pencil, "Edit entry", competitor.Id);
                edit.Click += EditEntry_Click;
                var del = CreateIconButton(PackIconMaterialKind.Delete, "Delete entry", competitor.Id);
                del.Click += DeleteEntry_Click;
                actions.Children.Add(edit);
                actions.Children.Add(del);

                Grid.SetColumn(actions, 7);
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

                    // After editing an entry, underlying data likely changed — rebuild view to reflect edits
                    RefreshView();
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
                    // Rebuild view after delete
                    RefreshView();
                    GlobalEvents.RaiseCompetitionEntriesChanged();
                    GlobalEvents.RaiseVehiclesChanged();
                }
            }
        }

        private void AddCompetitionButton_Click(object sender, RoutedEventArgs e)
        {
            var addCompetitionWindow = new AddCompetitionWindow
            {
                ShowInTaskbar = true,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            var parent = Window.GetWindow(this);
            parent.IsEnabled = false; // block parent

            // Prevent parent from closing while child is open
            void closingHandler(object? s, CancelEventArgs args)
            {
                if (addCompetitionWindow != null && addCompetitionWindow.IsVisible)
                {
                    args.Cancel = true; // block the close
                    addCompetitionWindow.Activate(); // bring child forward
                }
            }
            parent.Closing += closingHandler;

            addCompetitionWindow.Closed += (s, args) =>
            {
                parent.IsEnabled = true; // re-enable parent
                parent.Activate();       // bring parent back to front
                parent.Closing -= closingHandler; // remove handler

                // After adding a competition, reload the competition list
                LoadCompetitions();
            };

            addCompetitionWindow.Show();
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

                    // After adding an entry, rebuild the view and reload
                    RefreshView();
                    GlobalEvents.RaiseCompetitionEntriesChanged();
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

                    // Reset current and view
                    _currentCompetition = null;
                    if (GlobalData.Competitions.Count > 0)
                    {
                        _currentCompetition = GlobalData.Competitions[0];
                        CompetitionSelect.SelectedItem = _currentCompetition.Name;
                    }

                    _viewCompetitors.Clear();
                    RefreshView();
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
                
                RefreshView();
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
                RefreshView();
            }
        }

        private void ClearFilters_Click(object sender, RoutedEventArgs e)
        {
            FilterType = 0;
            FilterResult.Clear();
            // Rebuild view to remove any filter-induced state
            RefreshView();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            // Clear filters
            FilterType = 0;
            FilterResult.Clear();

            // Current sort
            _currentSort = SortType.Default;

            // Restore original ordering for the current competition
            RefreshView();
        }

        private void SortByDefault_Click(object sender, RoutedEventArgs e)
        {
            _currentSort = SortType.Default;
            RefreshView();
        }

        private void SortByDateAsc_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCompetition == null) return;

            _currentSort = SortType.DateAsc;
            RefreshView();
        }

        private void SortByDateDesc_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCompetition == null) return;

            _currentSort = SortType.DateDesc;
            RefreshView();
        }
    }
}
