
using System.Text.Json;

namespace Client
{
    internal class CatData
    {
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }

    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.thecatapi.com/v1/images/search";
            var response = await client.GetAsync(url);
            //
            // Console.WriteLine($"Response: {response}");
            string answer = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"String Answar: {answer}");
            Console.WriteLine(answer[0]);
            var catArr = JsonSerializer.Deserialize<CatData[]>(answer);
            Console.WriteLine(catArr[0].url);

        }
    }
}
