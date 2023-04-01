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
                if (value is string stringValue)
                    return !string.IsNullOrWhiteSpace(stringValue);

                return value != null;

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
