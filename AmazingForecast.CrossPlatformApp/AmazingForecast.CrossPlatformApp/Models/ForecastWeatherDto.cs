using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingForecast.CrossPlatformApp.Models
{
    public class ForecastWeatherDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string meteogram { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string date { get; set; }
        public string date_br { get; set; }
        public Humidity humidity { get; set; }
        public Rain rain { get; set; }
        public Wind wind { get; set; }
        public Uv uv { get; set; }
        public Thermal_Sensation thermal_sensation { get; set; }
        public Text_Icon text_icon { get; set; }
        public Temperature temperature { get; set; }
        public Cloud_Coverage cloud_coverage { get; set; }
        public Sun sun { get; set; }
    }

    public class Humidity
    {
        public int min { get; set; }
        public int max { get; set; }
        public Dawn dawn { get; set; }
        public Morning morning { get; set; }
        public Afternoon afternoon { get; set; }
        public Night night { get; set; }
    }

    public class Dawn
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Morning
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Afternoon
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Night
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Rain
    {
        public int probability { get; set; }
        public int precipitation { get; set; }
    }

    public class Wind
    {
        public int velocity_min { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
        public int gust_max { get; set; }
        public int direction_degrees { get; set; }
        public string direction { get; set; }
        public Dawn1 dawn { get; set; }
        public Morning1 morning { get; set; }
        public Afternoon1 afternoon { get; set; }
        public Night1 night { get; set; }
    }

    public class Dawn1
    {
        public string direction { get; set; }
        public int direction_degrees { get; set; }
        public int gust_max { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
    }

    public class Morning1
    {
        public string direction { get; set; }
        public int direction_degrees { get; set; }
        public int gust_max { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
    }

    public class Afternoon1
    {
        public string direction { get; set; }
        public int direction_degrees { get; set; }
        public int gust_max { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
    }

    public class Night1
    {
        public string direction { get; set; }
        public int direction_degrees { get; set; }
        public int gust_max { get; set; }
        public int velocity_max { get; set; }
        public int velocity_avg { get; set; }
    }

    public class Uv
    {
        public float max { get; set; }
    }

    public class Thermal_Sensation
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Text_Icon
    {
        public Icon icon { get; set; }
        public Text text { get; set; }
    }

    public class Icon
    {
        public string dawn { get; set; }
        public string morning { get; set; }
        public string afternoon { get; set; }
        public string night { get; set; }
        public string day { get; set; }
    }

    public class Text
    {
        public string pt { get; set; }
        public string en { get; set; }
        public string es { get; set; }
        public Phrase phrase { get; set; }
    }

    public class Phrase
    {
        public string reduced { get; set; }
        public string morning { get; set; }
        public string afternoon { get; set; }
        public string night { get; set; }
        public string dawn { get; set; }
    }

    public class Temperature
    {
        public int min { get; set; }
        public int max { get; set; }
        public Dawn2 dawn { get; set; }
        public Morning2 morning { get; set; }
        public Afternoon2 afternoon { get; set; }
        public Night2 night { get; set; }
    }

    public class Dawn2
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Morning2
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Afternoon2
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Night2
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Cloud_Coverage
    {
        public float low { get; set; }
        public float mid { get; set; }
        public int high { get; set; }
        public Dawn3 dawn { get; set; }
        public Morning3 morning { get; set; }
        public Afternoon3 afternoon { get; set; }
        public Night3 night { get; set; }
    }

    public class Dawn3
    {
        public float low { get; set; }
        public int mid { get; set; }
        public int high { get; set; }
    }

    public class Morning3
    {
        public float low { get; set; }
        public int mid { get; set; }
        public int high { get; set; }
    }

    public class Afternoon3
    {
        public float low { get; set; }
        public float mid { get; set; }
        public int high { get; set; }
    }

    public class Night3
    {
        public float low { get; set; }
        public float mid { get; set; }
        public int high { get; set; }
    }

    public class Sun
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }

}
