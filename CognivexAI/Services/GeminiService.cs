using CognivexAI.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CognivexAI.Services
{
    public class GeminiService : IGeminiService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public GeminiService(
            IConfiguration configuration,
            HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task<string> GenerateResponseAsync(
            string prompt)
        {
            var apiKey =
                _configuration["OpenRouterSettings:ApiKey"];

            var url =
                "https://openrouter.ai/api/v1/chat/completions";

            var requestBody = new
            {
                model = "openai/gpt-3.5-turbo",

                messages = new[]
    {
        new
        {
            role = "user",
            content = prompt
        }
    }
            };

            var json =
                JsonConvert.SerializeObject(requestBody);

            var request =
                new HttpRequestMessage(
                    HttpMethod.Post,
                    url);

            request.Headers.Add(
                "Authorization",
                $"Bearer {apiKey}");

            request.Headers.Add(
                "HTTP-Referer",
                "http://localhost");

            request.Headers.Add(
                "X-Title",
                "CognivexAI");
            request.Headers.Add(
                "User-Agent",
                "CognivexAI");

            request.Content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json");

            var response =
                await _httpClient.SendAsync(request);

            var responseString =
                await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return responseString;
            }

            dynamic? result =
                JsonConvert.DeserializeObject(responseString);

            return result?.choices?[0]
                ?.message
                ?.content
                ?.ToString()
                ?? "No AI response generated.";
        }
    }
}