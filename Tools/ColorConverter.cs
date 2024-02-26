using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_UI_Testing.Tools
{
    public class BackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte ColorAdjustValue = 80;
            Color inColor = (Color)value;
            Color adjustColor = Color.FromArgb(0, (byte)ColorAdjustValue, (byte)ColorAdjustValue, (byte)ColorAdjustValue);
            Color outcolor = Color.Subtract(inColor, adjustColor);
            return outcolor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class MouseOverColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte ColorAdjustValue = 60;
            Color inColor = (Color)value;
            Color adjustColor = Color.FromArgb(0, (byte)ColorAdjustValue, (byte)ColorAdjustValue, (byte)ColorAdjustValue);
            Color outcolor = Color.Subtract(inColor, adjustColor);
            return outcolor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ClickedColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte ColorAdjustValue = 90;
            Color inColor = (Color)value;
            Color adjustColor = Color.FromArgb(0, (byte)ColorAdjustValue, (byte)ColorAdjustValue, (byte)ColorAdjustValue);
            Color outcolor = Color.Subtract(inColor, adjustColor);
            return outcolor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
