//using Java.Lang;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Converters
{
    public class WeatherCodeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (int)value;

            switch (code)
            {
                case 0:  return "clearsky.png"; 
                case 1:  return "cloudy.png"; 
                case 2:  return "cloudy.png"; 
                case 3:  return "cloudy.png"; 
                case 45: return "fog.png"; 
                case 48: return "fog.png"; 
                case 51: return "drizzle.png"; 
                case 53: return "drizzle.png"; 
                case 55: return "drizzle.png"; 
                case 56: return "freezingdrizzle.png"; 
                case 57: return "freezingdrizzle.png"; 
                case 61: return "rain.png"; 
                case 63: return "rain.png"; 
                case 65: return "rain.png"; 
                case 66: return "freezingrain.png"; 
                case 67: return "freezingrain.png"; 
                case 71: return "snowfall.png"; 
                case 73: return "snowfall.png"; 
                case 75: return "snowfall.png"; 
                case 77: return "snowgrains.png"; 
                case 80: return "rainshowers.png"; 
                case 81: return "rainshowers.png"; 
                case 82: return "rainshowers.png"; 
                case 85: return "snowshowers.png"; 
                case 86: return "snowshowers.png"; 
                case 95: return "thunderstorm.png"; 
                case 96: return "hail.png"; 
                default: return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
