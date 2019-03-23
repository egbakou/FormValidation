using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace FormValidation.Converters
{
    /// <summary>
    /// Converter that check if username is correct and return true, otherwise return false.
    /// The idea is to be able to show or hide username error label.
    /// </summary>
    public class UsernameCorrectToHideLabelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return isUserNameCorrect(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private bool isUserNameCorrect(object value)
        {
            if (value == null || ((string)value).Length == 0)
                return true;

            if (value is string)
            {
                bool isEmail = Regex.IsMatch(
                    (string)value, "^[a-z0-9._-]+@[a-z0-9._-]+\\.[a-z]{2,6}$");

                int length = ((string)value).Trim().Length;
                if (length >= 7 && length <= 60 && isEmail)
                    return true;
                else
                    return false;

            }
            return false;
        }
    }
}
