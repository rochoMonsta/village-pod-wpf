using System;
using System.Globalization;
using System.Windows.Data;

namespace VillagePod.Utility.Converters
{
    public class NotNullOrEmptyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var text = value as string;
                return !string.IsNullOrWhiteSpace(text);
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
