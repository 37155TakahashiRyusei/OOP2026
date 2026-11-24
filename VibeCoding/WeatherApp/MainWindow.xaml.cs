using System.Windows;

namespace WeatherApp {
    public partial class MainWindow : Window {
        private readonly WeatherService weatherService = new();

        public MainWindow() {
            InitializeComponent();
        }

        private async void GetWeather_Click( object sender,RoutedEventArgs e) {
            var weather = await weatherService.GetWeatherAsync();

            WeatherText.Text =
                $"天気 : {weather.Weather}";

            TemperatureText.Text =
                $"気温 : {weather.Temperature} ℃";

            HumidityText.Text =
                $"湿度 : {weather.Humidity} %";

            WindText.Text =
                $"風速 : {weather.WindSpeed} km/h";
        }
    }
}