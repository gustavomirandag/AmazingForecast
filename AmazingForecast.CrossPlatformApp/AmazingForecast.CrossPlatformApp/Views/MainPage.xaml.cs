using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using AmazingForecast.CrossPlatformApp.Services;

namespace AmazingForecast.CrossPlatformApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //GetLocation
            //String placemark = GetDeviceLocationAsync().Result;
            //DisplayAlert("Location", placemark, "Ok");

            //DisplayCurrentWeather
            DisplayCurrentWeather();
            DisplayForecastWeather();
        }


        private void DisplayCurrentWeather()
        {
            var service = new ForecastService();
            var currentWeather = service.GetCurrentWeather().Result;

            //Fill interface components
            LabelState.Text = currentWeather.state;
            LabelCountry.Text = currentWeather.country;
            LabelTemperature.Text = currentWeather.data.temperature.ToString();
            LabelHumidity.Text = currentWeather.data.humidity.ToString();
            LabelDate.Text = currentWeather.data.date;
            ImageIcon.Source = ImageSource.FromResource($"mob{currentWeather.data.icon}.png");
            //if (Device.RuntimePlatform == Device.Android)
            //ImageIcon.Source = ImageSource.FromFile($"mob{currentWeather.data.icon}.png");

        }

        private void DisplayForecastWeather()
        {
            var service = new ForecastService();
            var forecastWeather = service.GetForecastWeather().Result;

            foreach(var day in forecastWeather.data.Skip(1))
            {
                var labelDate = new Label();
                labelDate.Text = day.date_br;
                labelDate.StyleClass = new List<string> { "dayLabel" };

                var labelTemperature = new Label();
                labelTemperature.Text = $"{day.temperature.min.ToString()}°C - {day.temperature.max.ToString()}°C";

                var labelHumidity = new Label();
                labelHumidity.Text = $"{day.humidity.min.ToString()}% - {day.humidity.max.ToString()}%";

                var labelDescription = new Label();
                labelDescription.Text = day.text_icon.text.phrase.reduced;

                var image = new Image();
                image.Source = ImageSource.FromFile($"mob{day.text_icon.icon.day}.png");


                var stackLayoutDay = new StackLayout();
                stackLayoutDay.Children.Add(labelDate);
                stackLayoutDay.Children.Add(labelTemperature);
                stackLayoutDay.Children.Add(labelHumidity);
                stackLayoutDay.Children.Add(labelDescription);
                stackLayoutDay.Children.Add(image);

                StackLayoutNextDays.Children.Add(stackLayoutDay);
            }
            

        }

        private async Task<String> GetDeviceLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    var placemark = await GetGeocoding(location.Latitude, location.Longitude);
                    //return $"Latitude: {location.Latitude} e Longitude: {location.Longitude}";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "Location desativado ou não encontrado.";
        }

        private async Task<String> GetGeocoding(double lat, double lon)
        {
            try
            {
                var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    var geocodeAddress =
                        $"AdminArea:       {placemark.AdminArea}\n" +
                        $"CountryCode:     {placemark.CountryCode}\n" +
                        $"CountryName:     {placemark.CountryName}\n" +
                        $"FeatureName:     {placemark.FeatureName}\n" +
                        $"Locality:        {placemark.Locality}\n" +
                        $"PostalCode:      {placemark.PostalCode}\n" +
                        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                        $"SubLocality:     {placemark.SubLocality}\n" +
                        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                        $"Thoroughfare:    {placemark.Thoroughfare}\n";

                    return geocodeAddress;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }

            return "";
        }
    }
}