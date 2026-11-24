namespace WeatherApp.Models {
    public class WeatherData {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string Weather { get; set; } = "";

        public List<DailyForecast> Forecasts { get; set; } = new();
    }
}