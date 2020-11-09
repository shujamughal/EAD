using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Lecture33_wpf
{
    class CoverterClass : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string val1 = values[0].ToString();
            string val2 = values[1].ToString();

            if (values.Count() >= 2)
            {

                if (string.IsNullOrEmpty(val1) || string.IsNullOrEmpty(val2))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else {
                return false;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
