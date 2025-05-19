using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeriesAnalyzer
{
    internal class Program
    {
        /// <summary>
        /// Displays the welcome message and instructions to the user.
        /// </summary>
        static void WelcomeMessage()
        {
            Console.WriteLine(
                "Welcome to The Series Analyzer!\n\n" +
                "At any point of the program Enter 'j' to Exit.");
        }

        /// <summary>
        /// Parses and validates the initial series, using command-line args if valid,
        /// otherwise prompts the user until a valid series or exit command is received.
        /// </summary>
        /// <param name="currentSeries">
        /// Initial series of string tokens (from args or prior input).
        /// </param>
        /// <returns>
        /// A valid string[] of tokens or a single-element ["j"] to indicate exit.
        /// </returns>
        static string[] GetSeries(string[] currentSeries)
        {
            bool validated = Validate(currentSeries);
            while (!validated)
            {
                Console.WriteLine(
                "\nNo series was entered.\n" +
                "Or the current series is invalid.\n" +
                "Please Enter a Series of rational numbers saperated by space " +
                "(at least 3 positive numbers!):\n\n" +
                "(You can Enter 'j' to Exit).\n");
                currentSeries = Console.ReadLine().Split(' ');
                if (currentSeries.Length == 1 && currentSeries[0] == "j")
                {
                    return currentSeries;
                }
                validated = Validate(currentSeries);
            }
            return currentSeries;
        }
        /// <summary>
        /// Prompts the user to replace the current series with a new one.
        /// </summary>
        /// <returns>
        /// The new series tokens (or ["j"] to indicate exit).
        /// </returns>
        static string[] ReplaceSeries()
        {
            Console.WriteLine(
                "Please Enter a New Series of rational numbers saperated by space " +
                "(at least 3 positive numbers!):\n\n" +
                "(You can Enter 'j' to Exit).\n");
            string[] newSeries = Console.ReadLine().Split(' ');
            return newSeries;
        }
        /// <summary>
        /// Validates that the provided tokens can be parsed to at least three positive doubles.
        /// </summary>
        /// <param name="series">Array of string tokens to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        static bool Validate(string[] series)
        {
            int positiveNumbers = 0;
            double indicator;
            bool isDouble;
            foreach (string str in series)
            {
                isDouble = double.TryParse(str, out indicator);
                if (!isDouble)
                {
                    return false;
                }
                if (indicator > 0)
                {
                    positiveNumbers++;
                }
            }
            if (positiveNumbers < 3)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Converts an array of numeric-string tokens to a double[].
        /// </summary>
        /// <param name="series">String tokens representing numbers.</param>
        /// <returns>Parsed double array.</returns>
        static double[] ConvertToDoubles(string[] series)
        {
            double[] doubles = new double[series.Length];
            for (int i = 0; i < series.Length; i++)
            {
                doubles[i] = Convert.ToDouble(series[i]);
            }
            return doubles;
        }
        /// <summary>
        /// Writes the numeric series to the console in its current order.
        /// </summary>
        /// <param name="series">Double array to display.</param>
        static void DisplaySeries(double[] series)
        {
            foreach (double num in series)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Returns a new double[] containing the elements of the input in reverse order.
        /// </summary>
        /// <param name="series">Original series.</param>
        /// <returns>Reversed series.</returns>
        static double[] Reverse(double[] series)
        {
            double[] reversed = new double[series.Length];
            for (int i = series.Length - 1; i >= 0; i--)
            {
                reversed[series.Length - i - 1] = series[i];
            }
            return reversed;
        }
        /// <summary>
        /// Returns a new double[] sorted in ascending order using bubble-sort with early exit.
        /// </summary>
        /// <param name="series">Original series.</param>
        /// <returns>Sorted series.</returns>
        static double[] Sort(double[] series)
        {
            double[] sorted = series.ToArray();
            bool done;
            double temp;
            for (int i = 0; i < sorted.Length; i++)
            {
                done = true;
                for (int j = 0; j < sorted.Length - i - 1; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                        done = false;
                    }
                }
                if (done)
                {
                    break;
                }

            }
            return sorted;
        }
        /// <summary>
        /// Computes the maximum value in the series.
        /// </summary>
        /// <param name="series">Series to analyze.</param>
        /// <returns>Maximum element.</returns>
        static double Max(double[] series)
        {
            double max = series[0];
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] > max)
                {
                    max = series[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Computes the minimum value in the series.
        /// </summary>
        /// <param name="series">Series to analyze.</param>
        /// <returns>Minimum element.</returns>
        static double Min(double[] series)
        {
            double min = series[0];
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] < min)
                {
                    min = series[i];
                }
            }
            return min;
        }
        /// <summary>
        /// Computes the sum of all elements in the series.
        /// </summary>
        /// <param name="series">Series to analyze.</param>
        /// <returns>Sum of elements.</returns>
        static double Sum(double[] series)
        {
            double sum = 0;
            foreach (double num in series)
            {
                sum += num;
            }
            return sum;
        }
        /// <summary>
        /// Computes the arithmetic average of the series.
        /// </summary>
        /// <param name="series">Series to analyze.</param>
        /// <returns>Average value.</returns>
        static double Average(double[] series)
        {
            double average = Sum(series) / Convert.ToDouble(series.Length);
            return average;
        }
        /// <summary>
        /// Displays the main menu of operations along with the current series.
        /// </summary>
        /// <param name="series">Series to display in the menu header.</param>
        static void DisplayMenu(double[] series)
        {
            Console.Write($"\nCurrent Series: ");
            DisplaySeries(series);
            Console.WriteLine(
                "Menu:\n\n" +
                "a. Input a Series. (Replace the current series)\n\n" +
                "b. Display the series in the order it was entered.\n\n" +
                "c. Display the series in the reversed order it was entered.\n\n" +
                "d. Display the series in sorted order (from low to high).\n\n" +
                "e. Display the Max value of the series.\n\n" +
                "f. Display the Min value of the series.\n\n" +
                "g. Display the Average of the series.\n\n" +
                "h. Display the Number of elements in the series.\n\n" +
                "i. Display the Sum of the series.\n\n" +
                "j. Exit.\n\n" +
                "Please enter your choice (a, b, etc.):\n"
                );
        }
        /// <summary>
        /// Reads and returns the user’s menu choice.
        /// </summary>
        /// <returns>Single-letter choice string.</returns>
        static string GetChoice()
        {
            string choice = Console.ReadLine();
            Console.WriteLine();
            return choice;
        }
        /// <summary>
        /// Validates and executes the user’s menu choice against the series.
        /// Prints results or prompts for replacement/exit.
        /// </summary>
        /// <param name="choice">User’s single-letter selection.</param>
        /// <param name="series">Current numeric series.</param>
        /// <returns>True if the choice was valid; otherwise, false.</returns>
        static bool ActivateChoice(string choice, double[] series)
        {
            bool validated;
            string validOptions = "abcdefghij";
            if (validOptions.Contains(choice))
            {
                validated = true;
                Console.WriteLine($"You selected option '{choice}':\n");
            }
            else
            {
                validated = false;
            }
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Input a Series.\n\n");
                        break;
                    case "b":
                        Console.Write("The Current Series: ");
                        DisplaySeries(series);
                        break;
                    case "c":
                        Console.Write("Reversed order of the Series: ");
                        DisplaySeries(Reverse(series));
                        break;
                    case "d":
                        Console.Write("Sorted order of the Series: ");
                        DisplaySeries(Sort(series));
                        break;
                    case "e":
                        Console.Write("Max Value of the Series: ");
                        Console.WriteLine($"{Max(series)}\n");
                        break;
                    case "f":
                        Console.Write("Min Value of the Series: ");
                        Console.WriteLine($"{Min(series)}\n");
                        break;
                    case "g":
                        Console.Write("Average of the Series: ");
                        Console.WriteLine($"{Average(series)}\n");
                        break;
                    case "h":
                        Console.WriteLine($"Number of Elements in the Series: {series.Length}");
                        break;
                    case "i":
                        Console.Write("Sum of the Series: ");
                        Console.WriteLine($"{Sum(series)}\n");
                        break;
                    case "j":
                        Console.WriteLine("Exit.");
                        break;
                    default:
                        break;
                }
            return validated;
        }
        /// <summary>
        /// Drives the interactive analysis loop: displays menu, processes choices,
        /// and handles series replacement or exit requests.
        /// </summary>
        /// <param name="currentSeries">Starting series tokens.</param>
        static void Analyze(string[] currentSeries)
        {
            bool toExit = false;
            while (!toExit)
            {
                if (currentSeries.Length == 1 && currentSeries[0] == "j")
                {
                    toExit = true;
                    continue;
                }
                double[] doubleSeries = ConvertToDoubles(currentSeries);
                DisplayMenu(doubleSeries);
                string choice = GetChoice();
                bool activated = ActivateChoice(choice, doubleSeries);
                while (!activated)
                {
                    Console.WriteLine("Invalid input!\n");
                    Console.WriteLine("Please enter (a, b, etc.)\n");
                    DisplayMenu(doubleSeries);
                    choice = GetChoice();
                    activated = ActivateChoice(choice, doubleSeries);
                }
                if (choice == "a")
                {
                    currentSeries = ReplaceSeries();
                }
                if (choice == "j")
                {
                    toExit = true;
                }
            }
        }
        /// <summary>
        /// Displays a friendly exit message.
        /// </summary>
        static void ExitMessage()
        {
            Console.WriteLine(
                "\nThank you for using our series analyzer!\n\n" +
                "We look forward to seeing you again!");
        }
        /// <summary>
        /// Program entry point. Handles welcome, initial series load, analysis, and exit.
        /// </summary>
        /// <param name="args">Optional command-line arguments for initial series.</param>
        static void Main(string[] args)
        {
            WelcomeMessage();          
            string[] series = GetSeries(args);
            Analyze(series);
            ExitMessage();
        }
    }
}
