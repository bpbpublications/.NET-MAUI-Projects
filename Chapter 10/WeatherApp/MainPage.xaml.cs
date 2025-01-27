using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json;
using WeatherApp.MVVM.Models;

namespace WeatherApp;

public partial class MainPage : ContentPage
{

    //public WeatherData weatherData { get; set; }
    //public string PlaceName { get; set; }
    //public DateTime Date { get; set; } = DateTime.Now;

    //public HttpClient client;

    public MainPage()
    {
        InitializeComponent();
        //client = new HttpClient();
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    {
    //        var location = await GetCoordinatesAsync(searchText.Text);
    //        await GetWeather(location);

    //        //var address = "Bangalore"; //searchText.Text; 
    //        //Debug.WriteLine("******** " + address);

    //            //IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

    //            //Location location = locations?.FirstOrDefault();

    //            //if (location != null)
    //            //{
    //            //    Debug.WriteLine($"********** Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");

    //            //    var url =
    //            //   $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,weathercode&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=auto";



    //            //    var response = await client.GetAsync(url);

    //            //    if (response.IsSuccessStatusCode)
    //            //    {
    //            //        Debug.WriteLine("******** Received data from API");
    //            //       // using (var responseStream = await response.Content.ReadAsStreamAsync())
    //            //        {

    //            //            var responseStream = await response.Content.ReadAsStringAsync();
    //            //            Debug.WriteLine($"*********** {responseStream}");


    //            //            var data = JObject.Parse(responseStream);
    //            //            Debug.WriteLine(data);


    //            //            // CURRENT TEMP & WEATHER

    //            //            //var data = await JsonSerializer.DeserializeAsync<Newtonsoft.Json.Linq.JObject>(responseStream);
    //            //            //Debug.WriteLine("******** Data received is as follows");
    //            //            //Debug.WriteLine(data["current_weather"]["temperature_2m"]);
    //            //            //Debug.WriteLine(data["current_weather"]["weathercode"]);

    //            //            //weatherData = new WeatherData() { current = data.current, daily = data.daily };
    //            //            //Debug.WriteLine($"********{weatherData.current.temperature_2m}");
    //            //            //Debug.WriteLine($"********{weatherData.daily.temperature_2m_max}");
    //            //            //Debug.WriteLine($"********{weatherData.daily.temperature_2m_min}");
    //            //            //Debug.WriteLine($"********{weatherData.daily.weathercode}");

    //            //            JArray dailyForecasts = (JArray)data["daily"];

    //            //            if (dailyForecasts != null)
    //            //            {
    //            //                foreach (var dailyForecast in dailyForecasts)
    //            //                {
    //            //                    var date = dailyForecast["datetime"].ToString();
    //            //                    var minTemp = (double)dailyForecast["temperature_2m_min"];
    //            //                    var maxTemp = (double)dailyForecast["temperature_2m_max"];
    //            //                    var weatherCode = (int)dailyForecast["weathercode"];

    //            //                    Debug.WriteLine($"**********{date} | {minTemp} | {maxTemp} | {weatherCode}");

    //            //                }
    //            //}

           

    //        //        var location = await GetCoordinatesAsync(address);
    //        //        Debug.WriteLine(location);
    //        //        await GetWeather(location);

    //    }
    //}

    //private async Task GetWeather(Location location)
    //{
    //    var url =
    //   $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,weathercode&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=auto";

    //    var response = await client.GetAsync(url);

    //    if (response.IsSuccessStatusCode)
    //    {
    //        var res = await response.Content.ReadAsStringAsync();

    //        var wdata = JsonConvert.DeserializeObject<JObject>(res);

    //        Debug.WriteLine(wdata);
    //        Debug.WriteLine(wdata["current"]["temperature_2m"]);
    //        Debug.WriteLine(wdata["current"]["weathercode"]);

    //        var dailywdata = wdata["daily"];

    //        for (int i = 0; i < 7; i++)
    //        {
    //            Debug.WriteLine(dailywdata["time"][i].ToString());
    //            Debug.WriteLine(dailywdata["weathercode"][i].ToString());
    //            Debug.WriteLine(dailywdata["temperature_2m_max"][i].ToString());
    //            Debug.WriteLine(dailywdata["temperature_2m_min"][i].ToString());
    //        }
    //    }
    //    else
    //    {
    //        Debug.WriteLine("******** Failed to get the weather data");
    //    }
    //}

    ////private async Task GetWeather(Location location)
    ////{
    ////    var url =
    ////        $"https://api.open-meteo.com/v1/forecast?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Asia%2FBangkok&forecast_days=1";

    ////    var response = await client.GetAsync(url);

    ////    if (response.IsSuccessStatusCode)
    ////    {
    ////        using (var responseStream = await response.Content.ReadAsStreamAsync())
    ////        {
    ////            var data = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
    ////            Debug.WriteLine(data);
    ////        }
    ////    }
    ////}

    //private async Task<Location> GetCoordinatesAsync(string address)
    //{
    //    IEnumerable<Location> locations = await Geocoding.Default.GetLocationsAsync(address);

    //    Location location = locations?.FirstOrDefault();

    //    if (location != null)
    //    {
    //        Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}");
    //    }
    //        return location;
    //}
}
