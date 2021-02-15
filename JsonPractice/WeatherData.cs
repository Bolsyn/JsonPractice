using System;
using System.Collections.Generic;
using System.Text;

namespace JsonPractice
{
    public class WeatherData
    {
        public RequestWeather Request { get; set; }
        public LocationWeather Location { get; set; }
        public CurrentWeather Current { get; set; }
    }
}
