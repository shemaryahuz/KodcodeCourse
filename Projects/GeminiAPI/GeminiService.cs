using System;
using System.Linq; // For .FirstOrDefault()
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization; // For JsonIgnoreCondition
using System.Threading.Tasks;

namespace GeminiAPI
{
    internal class GeminiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _modelName;

        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        public GeminiService(string apiKey, string modelName = "gemini-2.0-flash")
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _modelName = modelName;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private string GetApiUrl()
        {
            return $"https://generativelanguage.googleapis.com/v1beta/models/{_modelName}:generateContent?key={_apiKey}";
        }
        public async Task<string> GenerateTextAsync(string prompt)
        {
            var requestPayload = new GeminiRequest
            {
                Contents = new List<Content>
                {
                    new Content
                    {
                        Parts = new List<Part>
                        {
                            new Part
                            {
                                Text = prompt
                            }
                        }
                    }
                }
            };
            string jsonRequest = JsonSerializer.Serialize(requestPayload, _jsonSerializerOptions);
            var httpContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            //try
            //{
            //    await Task.Delay(1);
            //    return "Temporary placeholder response";
            //}
            //catch (Exception)
            //{
            //    return null;
            //}
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(GetApiUrl(), httpContent);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"API Error:{response.StatusCode}");
                    Console.WriteLine($"Details from API:{jsonResponse}");
                    Console.ResetColor();
                    return null;
                }
                var geminiResponse = JsonSerializer.Deserialize<GeminiResponse>(jsonResponse, _jsonSerializerOptions);
                return geminiResponse?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text.Trim();
            }
            catch (HttpRequestException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"HTTP Request error: {e.Message}");
                Console.ResetColor();
                return null;
            }
            catch (JsonException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"JSON parsing error: {e.Message}");
                Console.ResetColor();
                return null;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An unexpected error occurred in GeminiService: {e.Message}");
                Console.ResetColor();
                return null;
            }
        }
    }
}
