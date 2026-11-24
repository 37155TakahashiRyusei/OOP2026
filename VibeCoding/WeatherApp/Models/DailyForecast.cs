namespace WeatherApp.Models {
    public class DailyForecast {
        public string Date { get; set; } = "";
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double PrecipitationProbability { get; set; }
    }
}
