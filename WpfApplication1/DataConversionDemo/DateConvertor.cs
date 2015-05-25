using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataConversionDemo
{
    public class DateConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("d");
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            string strValue = (string)value;
            DateTime resultDatetime;
            if (DateTime.TryParse(strValue, out resultDatetime))
            {
                return resultDatetime;
            }
            throw new Exception("Unable to convert string to date time.");
        }
    }
}
