using System;
using System.Globalization;
using System.Windows.Data;

namespace CompUIWPF
{
    // Converter returns singleton instances (lazy) of the views so switching tabs reuses the same controls.
    public class TabIndexToViewConverter : IValueConverter
    {
        private static readonly Lazy<CompUIWPF.Vehicles.Vehicles> _vehiclesInstance
            = new(() => new CompUIWPF.Vehicles.Vehicles());

        private static readonly Lazy<CompUIWPF.Competitions.CompetitionManager> _competitionsInstance
            = new(() => new CompUIWPF.Competitions.CompetitionManager());

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int index)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return index switch
                {
                    0 => _vehiclesInstance.Value,
                    1 => _competitionsInstance.Value,
                    _ => null
                };
#pragma warning restore CS8603 // Possible null reference return.
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}