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
            Console.WriteLine($"--- Gemini AI Chat (Model: {modelToUse}) ---");
            Console.WriteLine("Type 'exit' or 'quit' to end the session.");
            string userInput;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYou: ");
                Console.ResetColor();
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    continue;
                }
                if (userInput.Equals("exit",StringComparison.OrdinalIgnoreCase) || userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting chat. Goodbye!");
                    break;
                }
                Console.WriteLine("Gemini is thinking...");
                string generatedText = await geminiService.GenerateTextAsync(userInput);
                if (generatedText != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gemini: ");
                    Console.ResetColor();
                    Console.WriteLine(generatedText);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Gemini: Failed to get a response or an error occurred.");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\nSession ended. Press any key to close the application.");
            Console.ReadKey();
        }
    }
}
