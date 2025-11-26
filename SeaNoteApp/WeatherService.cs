using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeaNoteApp
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "1235b515bb8c9e82e326fbbca7908c02";
        private const string BaseUrl = "http://api.weatherstack.com/current";

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherResult?> GetCurrentWeatherAsync(string city)
        {
            // contoh: http://api.weatherstack.com/current?access_key=KEY&query=Jakarta&units=m
            var url = $"{BaseUrl}?access_key={ApiKey}&query={city}&units=m";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var result = JsonSerializer.Deserialize<WeatherResult>(json, options);
            return result;
        }
    }

    // ==== DTO sesuai JSON Weatherstack ====

    public class WeatherResult
    {
        public WeatherLocation? Location { get; set; }
        public WeatherCurrent? Current { get; set; }
    }

    public class WeatherLocation
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
    }

    public class WeatherCurrent
    {
        public double Temperature { get; set; }
        public string[]? Weather_Descriptions { get; set; }
    }
}
