using AmazingForecast.CrossPlatformApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AmazingForecast.CrossPlatformApp.Services
{
    public class ForecastService
    {
        public async Task<CurrentWeatherDto> GetCurrentWeather()
        {
            var httpClient = new HttpClient();
            var httpResult = httpClient.GetAsync("https://apiadvisor.climatempo.com.br/api/v1/weather/locale/5959/current?token=cc06630b1885654cdd719f5c9eacb442");
            var result = httpResult.Result;
            var serializedCurrentWeatherDto = await result.Content.ReadAsStringAsync();
            var currentWeatherDto = JsonConvert.DeserializeObject<CurrentWeatherDto>(serializedCurrentWeatherDto);

            return currentWeatherDto;
        }

        public async Task<ForecastWeatherDto> GetForecastWeather()
        {
            var httpClient = new HttpClient();
            var httpResult = httpClient.GetAsync("https://apiadvisor.climatempo.com.br/api/v1/forecast/locale/5959/days/15?token=cc06630b1885654cdd719f5c9eacb442");
            var result = httpResult.Result;
            var serializedForecastWeatherDto = await result.Content.ReadAsStringAsync();
            var forecastWeatherDto = JsonConvert.DeserializeObject<ForecastWeatherDto>(serializedForecastWeatherDto);

            return forecastWeatherDto;
        }
    }
}
