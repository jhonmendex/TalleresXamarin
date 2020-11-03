using System;
using System.Globalization;

namespace ejercicioOnPlatform.Convert
{
    public class MultiTriggerConverter
    {
        public MultiTriggerConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value > 0) // length > 0 ?
                return true; // some data has been entered
            else
                return false; // input is empty

        }
        public object ConvertBack(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
