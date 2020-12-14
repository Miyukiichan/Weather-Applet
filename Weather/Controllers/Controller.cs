using System;
using System.IO;
using Weather.Models;
using System.Net;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace Weather.Controllers
{
    class Controller
    {
        protected string APIURL = "https://api.openweathermap.org";
        protected string APIKey = "6578e6a82860fe2b0505569364b1aaf1";
        protected WebClient client = new WebClient();
        protected JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        protected TWeather weather;
        protected IEnumerable<Location> locations;
        protected IEnumerable<string> cities;
        protected string DataDir = Path.Combine("..", "..", "..", "Data");
        public IEnumerable<string> Countries { get; }
        public IEnumerable<string> Cities { get => cities; }
        protected string city;
        protected string units;
        protected string country;
        public Controller(string c = "United Kingdom", string l = "Swansea", string u = "C") 
        {
            city = l;
            units = u;
            country = c;
            var jsonFileReader = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), DataDir, "city.list.json"));
            locations = JsonSerializer.Deserialize<Location[]>(jsonFileReader.ReadToEnd(), options).Where(loc => loc.Country != null);
            Countries = locations.Select(loc => loc.Country).Distinct().OrderBy(s => s);
            RefreshCities();
        }

        public string City 
        {
            get => city;
            set
            {
                city = value;
            }
        }
        public string Country 
        { 
            get => country; 
            set
            {
                country = value;
                RefreshCities();
            }
        }
        public string Units
        {
            get => units;
            set
            {
                units = value;
            }
        }
        protected string UnitCode(string u)
        {
            return u switch
            {
                "C" => "metric",
                "F" => "imperial",
                _ => "standard",
            };
        }
        public void Refresh()
        {
            try
            {
                string address = $"{APIURL}/data/2.5/weather?q={City}&units={UnitCode(units)}&appid={APIKey}";
                string json = client.DownloadString(address);
                weather = JsonSerializer.Deserialize<TWeather>(json, options);
            }
            catch (Exception e) { }
        }
        protected void RefreshCities()
        {
            cities = locations.Where(loc => loc.Country == Country).Select(loc => loc.Name).Distinct().OrderBy(s => s);
        }
        public string MainWeather {
            get
            {
                string unit = Math.Round(weather.Main.Temp).ToString();
                return (unit.Length == 1 ? " " : "") + unit + Units.Replace("C", "°");
            }
        }
        public string IconFile
        {
            get => Path.Combine(DataDir, "Icons", weather.WeatherItems.First().Icon) + ".png";
        }
    }
}
