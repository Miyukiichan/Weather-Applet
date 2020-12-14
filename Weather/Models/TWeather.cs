using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Weather.Models
{
    public class TWeather
    {
        public Coord Coord { get; set; }
        [JsonPropertyName("Weather")]
        public WeatherItem[] WeatherItems { get; set; }
        public string Base { get; set; }
        public MainInfo Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int TimeZone { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
    public class WeatherItem
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
    public class MainInfo
    {
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public int Preassure { get; set; }
        public int Humidity { get; set; }
    }
    public class Wind
    {
        public double Speed { get; set; }
        public double Deg { get; set; }
    }
    public class Clouds
    {
        public int All { get; set; }
    }
    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }
}
