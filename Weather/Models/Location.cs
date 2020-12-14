using System;
using System.Globalization;

namespace Weather.Models
{
    class Location
    {
        protected string displayCountry;
        public double Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country 
        { 
            get => displayCountry; 
            set 
            {
                try
                {
                    displayCountry = new RegionInfo(value).DisplayName;
                }
                catch (Exception e) {}
            } 
        }
        public Coord Coord { get; set; }
    }
}
