using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Lecture_32_wpf_IvalueConverter
{
    class TextToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string data = value.ToString();
            if (data.Equals("check"))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool data = System.Convert.ToBoolean(value);

            if (data == true)

            {
                return "check";

            }
            else {

                return "uncheck";
            }
        }
    }
}
