using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Convertory.Convertors
{
    internal class Luminance : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush input)
            {
                Color color = input.Color;
                return ((0.2126 * color.ScR + 0.7152 * color.ScG + 0.0722 * color.ScB));
            }
            else { return default; }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
