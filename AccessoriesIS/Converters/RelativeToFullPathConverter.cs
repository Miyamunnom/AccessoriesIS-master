using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AccessoriesIS.Converters
{
    public class RelativeToFullPathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = value as string;
            if (string.IsNullOrWhiteSpace(path)) return "../resources/images/error-icon.png";
            try
            {
                return !File.Exists(path) ? "../resources/images/error-icon.png" : Path.GetFullPath(path);
            }
            catch (Exception)
            {
                return "../resources/images/error-icon.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
