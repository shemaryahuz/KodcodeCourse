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
        static double[] ConvertToDoubles(string[] series)
        {
            double[] doubles = new double[series.Length];
            for (int i = 0; i < series.Length; i++)
            {
                doubles[i] = Convert.ToDouble(series[i]);
            }
            return doubles;
        }
        static void DisplaySeries(double[] series)
        {
            foreach (double num in series)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");
        }
        static double[] Reverse(double[] series)
        {
            double[] reversed = new double[series.Length];
            for (int i = series.Length - 1; i >= 0; i--)
            {
                reversed[series.Length - i - 1] = series[i];
            }
            return reversed;
        }
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
        static double Sum(double[] series)
        {
            double sum = 0;
            foreach (double num in series)
            {
                sum += num;
            }
            return sum;
        }
        static double Average(double[] series)
        {
            double average = Sum(series) / Convert.ToDouble(series.Length);
            return average;
        }
        static string DisplayMenu(double[] series)
        {
            Console.Write($"\nCurrent Series: ");
            DisplaySeries(series);
            Console.WriteLine(
                "Menu:\n\n" +
                "a.Input a Series. (Replace the current series)\n\n" +
                "b.Display the series in the order it was entered.\n\n" +
                "c.Display the series in the reversed order it was entered.\n\n" +
                "d.Display the series in sorted order (from low to high).\n\n" +
                "e.Display the Max value of the series.\n\n" +
                "f.Display the Min value of the series.\n\n" +
                "g.Display the Average of the series.\n\n" +
                "h.Display the Number of elements in the series.\n\n" +
                "i.Display the Sum of the series.\n\n" +
                "j.Exit.\n\n" +
                "Please enter your choice (a, b, etc.):\n"
                );
            string choice = Console.ReadLine();
            Console.WriteLine();
            return choice;
        }
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
                        Console.Write("Current Series: ");
                        DisplaySeries(series);
                        break;
                    case "c":
                        Console.Write("Reversed Series: ");
                        DisplaySeries(Reverse(series));
                        break;
                    case "d":
                        Console.Write("Sorted Series: ");
                        DisplaySeries(Sort(series));
                        break;
                    case "e":
                        Console.Write("Max Value: ");
                        Console.WriteLine($"{Max(series)}\n");
                        break;
                    case "f":
                        Console.Write("Min Value: ");
                        Console.WriteLine($"{Min(series)}\n");
                        break;
                    case "g":
                        Console.Write("Average of Series: ");
                        Console.WriteLine($"{Average(series)}\n");
                        break;
                    case "h":
                        Console.WriteLine($"Number of Elements: {series.Length}");
                        break;
                    case "i":
                        Console.Write("Sum of Series: ");
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
        static void WelcomeMessage()
        {
            Console.WriteLine(
                "Welcome to The Series Analyzer!\n\n" +
                "At any point of the program Enter 'j' to Exit.");
        }
        static void ExitMessage()
        {
            Console.WriteLine(
                "\nThank you for using our series analyzer!\n\n" +
                "We look forward to seeing you again!");
        }
        static string[] GetSeries(string[] currentSeries)
        {
            bool validated = Validate(currentSeries);
            while (!validated)
            {
                if (currentSeries.Length == 1 && currentSeries[0] == "j")
                {
                    return currentSeries;
                }
                else
                {
                    Console.WriteLine(
                        "\nNo series was entered.\n" +
                        "Or the current series is invalid.\n");
                }
                Console.WriteLine(
                "Please Enter a Series of rational numbers saperated by space " +
                "(at least 3 positive numbers!):\n\n" +
                "(You can Enter 'j' to Exit).\n");
                currentSeries = Console.ReadLine().Split(' ');
                validated = Validate(currentSeries);
            }           
            return currentSeries;
        }
        static string[] ReplaceSeries()
        {
            Console.WriteLine(
                "Please Enter a New Series of rational numbers saperated by space " +
                "(at least 3 positive numbers!):\n\n" +
                "(You can Enter 'j' to Exit).\n");
            string[] newSeries = Console.ReadLine().Split(' ');
            return newSeries;
        }

        // To fix to replace option!!! if the user entered 'a'
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
                string choice = DisplayMenu(doubleSeries);
                bool activated = ActivateChoice(choice, doubleSeries);
                while (!activated)
                {
                    Console.WriteLine("Invalid input!\n");
                    Console.WriteLine("Please enter (a, b, etc.)\n");
                    choice = DisplayMenu(doubleSeries);
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
        static void Main(string[] args)
        {
            WelcomeMessage();          
            string[] currentSeries = GetSeries(args);
            Analyze(currentSeries);
            ExitMessage();
        }
    }
}
