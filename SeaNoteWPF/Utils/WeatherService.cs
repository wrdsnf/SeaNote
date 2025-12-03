using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaNoteWPF.Utils
{
    public static class WeatherService
    {
        public static async Task<(string temp, string condition)> GetWeather(string city)
        {
            double lat = -6.1751, lon = 106.8650; // Default Jakarta

            switch (city)
            {
                case "Surabaya": lat = -7.2575; lon = 112.7521; break;
                case "Batam": lat = 1.1301; lon = 104.0529; break;
                case "Makassar": lat = -5.1477; lon = 119.4327; break;
                case "Medan": lat = 3.5952; lon = 98.6722; break;
                case "Bali": lat = -8.4095; lon = 115.1889; break;
            }

            try
            {
                string url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,weather_code";

                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(url);
                    var json = JObject.Parse(response);

                    string temp = json["current"]?["temperature_2m"]?.ToString() + "°C";
                    int code = (int)(json["current"]?["weather_code"] ?? 0);

                    // Translate kode cuaca WMO
                    string cond = "Sunny";
                    if (code >= 1 && code <= 3) cond = "Cloudy";
                    else if (code >= 45 && code <= 48) cond = "Foggy";
                    else if (code >= 51 && code <= 67) cond = "Rainy";
                    else if (code >= 80) cond = "Storm";

                    return (temp, cond);
                }
            }
            catch
            {
                return ("--", "Offline");
            }
        }
    }
}