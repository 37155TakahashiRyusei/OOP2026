using System.Windows;

namespace WeatherApp {
    public partial class MainWindow : Window {
        private readonly WeatherService weatherService = new();

        public MainWindow() {
            InitializeComponent();
        }

        private async void GetWeather_Click(object sender, RoutedEventArgs e) {

                try {
                    var weather =
                        await weatherService.GetWeatherAsync();

                        // 現在の表示処理
                        WeatherText.Text =
                        $"天気 : {weather.Weather}";

                        TemperatureText.Text =
                            $"気温 : {weather.Temperature} ℃";

                        HumidityText.Text =
                            $"湿度 : {weather.Humidity} %";

                        WindText.Text =
                            $"風速 : {weather.WindSpeed} km/h";

                        ForecastList.Items.Clear();

                    foreach (var forecast in weather.Forecasts) {
                    ForecastList.Items.Add(
                        $"{forecast.Date}  " +
                        $"最高:{forecast.MaxTemperature}℃  " +
                        $"最低:{forecast.MinTemperature}℃  " +
                        $"降水:{forecast.PrecipitationProbability}%");

                    }

                } catch (Exception ex) {
                        MessageBox.Show(
                        $"通信エラー\n{ex.Message}",
                        "エラー");
                }
            

        }
    }
}