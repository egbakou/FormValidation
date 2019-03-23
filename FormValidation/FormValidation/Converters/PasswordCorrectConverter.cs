using System;
using System.Globalization;
using Xamarin.Forms;

namespace FormValidation.Converters
{
    /// <summary>
    /// Converter that check if passsword is correct and return true, otherwise return false.
    /// </summary>
    public class PasswordCorrectConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return isPasswordCorrect(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private bool isPasswordCorrect(object value)
        {
            if (value is string)
            {
                int length = ((string)value).Trim().Length;
                if (length >= 8)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
