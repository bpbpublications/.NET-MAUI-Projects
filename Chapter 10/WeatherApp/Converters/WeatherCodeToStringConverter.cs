//using Android.Hardware.Lights;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Converters
{
    public class WeatherCodeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var code = (int)value;

            switch (code)
            {
                case 0: return "Clear sky";
                case 1: return "Mainly clear";
                case 2: return "Partly cloudy";
                case 3: return "Overcast";
                case 45: return "Fog";
                case 48: return "Depositing rime fog";
                case 51: return "Drizzle: Light intensity";
                case 53: return "Drizzle: Moderate intensity";
                case 55: return "Drizzle: Dense intensity";
                case 56: return "Freezing Drizzle: Light intensity";
                case 57: return "Freezing Drizzle: Dense intensity";
                case 61: return "Rain: Slight intensity";
                case 63: return "Rain: Moderate intensity";
                case 65: return "Rain: Heavy intensity";
                case 66: return "Freezing Rain: Light intensity";
                case 67: return "Freezing Rain: Heavy intensity";
                case 71: return "Snow fall: Slight intensity";
                case 73: return "Snow fall: Moderate intensity";
                case 75: return "Snow fall: Heavy intensity";
                case 77: return "Snow grains";
                case 80: return "Rain showers: Slight";
                case 81: return "Rain showers: Moderate";
                case 82: return "Rain showers: Violent";
                case 85: return "Snow showers: Slight";
                case 86: return "Snow showers: Heavy";
                case 95: return "Thunderstorm: Slight or moderate";
                case 96:
                case 99: return "Thunderstorm with slight and heavy hail";
                default: return "Not defined";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
