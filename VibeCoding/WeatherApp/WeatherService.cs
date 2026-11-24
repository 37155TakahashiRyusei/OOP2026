using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;

namespace WeatherApp {
    public class WeatherService {
        private readonly HttpClient client = new();

        public async Task<WeatherData> GetWeatherAsync() {
            string url =
                        "https://api.open-meteo.com/v1/forecast" +
                        "?latitude=36.29" +
                        "&longitude=139.37" +
                        "&current=temperature_2m,relative_humidity_2m,wind_speed_10m,weather_code" +
                        "&daily=temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
                        "&forecast_days=7";

            string json = await client.GetStringAsync(url);

            using JsonDocument doc = JsonDocument.Parse(json);

            var forecasts = new List<DailyForecast>();

            JsonElement daily =
                doc.RootElement.GetProperty("daily");

            var dates =
                daily.GetProperty("time");

            var maxTemps =
                daily.GetProperty("temperature_2m_max");

            var minTemps =
                daily.GetProperty("temperature_2m_min");

            var precipitation =
                daily.GetProperty("precipitation_probability_max");

            for (int i = 0; i < dates.GetArrayLength(); i++) {
                forecasts.Add(new DailyForecast {
                    Date = dates[i].GetString() ?? "",
                    MaxTemperature = maxTemps[i].GetDouble(),
                    MinTemperature = minTemps[i].GetDouble(),
                    PrecipitationProbability =
                        precipitation[i].GetDouble()
                });
            }


            return new WeatherData {
                Temperature = doc.RootElement
                    .GetProperty("current")
                    .GetProperty("temperature_2m")
                    .GetDouble(),

                Humidity = doc.RootElement
                    .GetProperty("current")
                    .GetProperty("relative_humidity_2m")
                    .GetDouble(),

                WindSpeed = doc.RootElement
                    .GetProperty("current")
                    .GetProperty("wind_speed_10m")
                    .GetDouble(),

                Weather = GetWeatherDescription(doc.RootElement
                        .GetProperty("current")
                        .GetProperty("weather_code")
                        .GetInt32()),

                Forecasts = forecasts

            };
        }

        private string GetWeatherDescription(int code) {
            return code switch {
                0 => "快晴",
                1 => "晴れ",
                2 => "一部曇り",
                3 => "曇り",
                45 => "霧",
                51 => "小雨",
                61 => "雨",
                71 => "雪",
                _ => "不明"
            };
        }

    }
}