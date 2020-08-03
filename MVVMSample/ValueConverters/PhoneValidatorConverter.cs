using System;
using System.Globalization;
using Xamarin.Forms;

namespace MVVMSample.ValueConverters
{
    public class PhoneValidatorConverter : IValueConverter
    {
        public PhoneValidatorConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string phone = value as string;
            if(phone.Length == 10)
            {
                return Color.LimeGreen;
            }
            return Color.PaleVioletRed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
