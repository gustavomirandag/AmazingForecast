using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingForecast.CrossPlatformApp.Models
{


    public class CurrentWeatherDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public int temperature { get; set; }
        public string wind_direction { get; set; }
        public double wind_velocity { get; set; }
        public double humidity { get; set; }
        public string condition { get; set; }
        public double pressure { get; set; }
        public string icon { get; set; }
        public double sensation { get; set; }
        public string date { get; set; }
    }

}
