using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SeaNoteWPF.Utils
{
    public static class GeminiService
    {
        private static readonly string Endpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=" + ConfigHelper.GeminiApiKey;

        public static async Task<string> AskGemini(string prompt)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var requestBody = new { contents = new[] { new { parts = new[] { new { text = prompt } } } } };
                    var json = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(Endpoint, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode) return "Error: Gagal menghubungi Gemini.";

                    var jsonResponse = JObject.Parse(responseString);
                    return jsonResponse["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString() ?? "No response.";
                }
            }
            catch (Exception ex)
            {
                return "Connection Error: " + ex.Message;
            }
        }
    }
}