using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HelloWorld.Helpers
{
    public class DefaultName:IValueConverter
    {
        // Transform data from Target to Source
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string str=(string) value;
            if (str=="Male")return true;
            return false;
        }

        // Transform data from Source to target
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool chk = (bool)value;
            if (chk) return "Male";
            return "Female";
        }
    }
}
