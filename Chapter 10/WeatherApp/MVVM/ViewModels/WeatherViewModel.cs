using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using WeatherApp.MVVM.Models;


namespace WeatherApp.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class WeatherViewModel
    {

        public WeatherData Weather { get; set; }
        public string PlaceName { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public HttpClient client;

        public WeatherViewModel()
        {
            client = new HttpClient();
        }

        public ICommand SearchCommand =>
             new Command(async (searchText) =>
             {
                 PlaceName = searchText.ToString();
                 var location = await GetCoordinatesAsync(searchText.ToString());
                 await GetWeather(location);
             });

        private async Task GetWeather(Location location)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,weathercode&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=auto";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
                    Weather = data;

                    Debug.WriteLine($"*****{Weather.current.temperature_2m} | {Weather.current.weathercode}");

                    for (int i = 0; i < Weather.daily.time.Length; i++)
                    {
                        var dailyForecast = new DailyForecast {
                            time = Weather.daily.time[i],
                            temperature_2m_max = Weather.daily.temperature_2m_max[i],
                            temperature_2m_min = Weather.daily.temperature_2m_min[i],
                            weathercode = Weather.daily.weathercode[i]
                        };

                        Weather.dailyForecasts.Add(dailyForecast);
                    }

                }
            }
        }

        private async Task<Location> GetCoordinatesAsync(string address)
        {
            IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

            Location location = locations?.FirstOrDefault();

            if (location != null)
                Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");

            return location;
        }
    }
}
