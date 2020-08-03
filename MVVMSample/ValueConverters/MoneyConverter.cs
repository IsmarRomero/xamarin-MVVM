using System;
using System.Globalization;
using Xamarin.Forms;

namespace MVVMSample.ValueConverters
{
    public class MoneyConverter: IValueConverter
    {
        public MoneyConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = value.ToString();
            if(valor.ToString() != null)
            {
                var nuevoValor = valor.Insert(0, "$");
                return nuevoValor;
            } else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if(value.ToString()  != "")
            {
                var newValue =  value.ToString().Replace("$", "");
                return decimal.Parse(newValue ?? "0");
            }
           else
            {
                return 0;
            }
        }
    }
}
