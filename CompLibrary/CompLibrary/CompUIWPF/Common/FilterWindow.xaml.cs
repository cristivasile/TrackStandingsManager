using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompUIWPF.Common
{
    public partial class FilterWindow : Window
    {
        // temporary selection storage used by checkbox handlers
        private readonly HashSet<string> _selected = new();
        public List<string> Result { get; } = new();

        public FilterWindow(List<string> choices, string title = "Filter")
        {
            InitializeComponent();
            Title = title;
            ItemsList.ItemsSource = choices;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox cb && cb.Content is string s)
                _selected.Add(s);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox cb && cb.Content is string s)
                _selected.Remove(s);
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Result.Clear();
            Result.AddRange(_selected.OrderBy(x => x));
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}