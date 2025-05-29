using System.Text.Json.Serialization;
using System.Text.Json;

namespace GeminiAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CRITICAL ERROR: The GEMINI_API_KEY environment variable was not found.");
                Console.WriteLine("Please ensure it is set in your launchSettings.json or system environment variables.");
                Console.ResetColor();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return;
            }
            string modelToUse = "gemini-2.0-flash";
            var geminiService = new GeminiService(apiKey, modelToUse);
            Console.WriteLine("Enter your prompt:");
            string prompt = Console.ReadLine();
            Console.WriteLine($"Sending prompt to Gemini (model: {modelToUse}): \"{prompt}\"");
            Console.WriteLine("Waiting for response...");
            string generatedText = await geminiService.GenerateTextAsync(prompt);
            if (generatedText != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nGemini's Response:");
                Console.ResetColor();
                Console.WriteLine(generatedText);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nFailed to get a response from Gemini.");
                Console.ResetColor();
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
