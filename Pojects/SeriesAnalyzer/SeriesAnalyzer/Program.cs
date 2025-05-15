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
        static string[] GetSeries()
        {
            Console.WriteLine("Please enter series of rational numbers  saperated by space (at least 3 positive numbers!):\n");
            string[] series = Console.ReadLine().Split(' ');
            return series;
        }
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

        static int[] ConvertToInts(string[] series)
        {
            int[] ints = new int[series.Length];
            for (int i = 0; i < series.Length; i++)
            {
                ints[i] = Convert.ToInt32(series[i]);
            }
            return ints;
        }
        static void DisplaySeries(int[] series)
        {
            foreach (int num in series)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n");
        }
        static int[] Reverse(int[] series)
        {
            int[] reversed = new int[series.Length];
            for (int i = series.Length - 1; i >= 0; i--)
            {
                reversed[series.Length - i - 1] = series[i];
            }
            return reversed;
        }
        static int[] Sort(int[] series)
        {
            int[] sorted = series.ToArray();
            bool done;
            int temp;
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
        static int Max(int[] series)
        {
            int max = series[0];
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] > max)
                {
                    max = series[i];
                }
            }
            return max;
        }
        static int Min(int[] series)
        {
            int min = series[0];
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] < min)
                {
                    min = series[i];
                }
            }
            return min;
        }
        static int Sum(int[] series)
        {
            int sum = 0;
            foreach (int num in series)
            {
                sum += num;
            }
            return sum; 
        }
        static double Average(int[] series)
        {
            double average = Sum(series) / Convert.ToDouble(series.Length);
            return average;
        }
        static string DisplayMenu(int[] series)
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
        static void DisplayChoice(string choice)
        {
            Console.WriteLine($"You selected option '{choice}':\n");
        }
        static bool ActivateChoice(string choice, int[] series)
        {
            switch (choice)
            {
                case "a":
                    DisplayChoice(choice);
                    Console.WriteLine("Input a Series:\n\n");
                    return true;
                case "b":
                    DisplayChoice(choice);
                    Console.Write("Current Series: ");
                    DisplaySeries(series);
                    return true;
                case "c":
                    DisplayChoice(choice);
                    Console.Write("Reversed Series: ");
                    DisplaySeries(Reverse(series));
                    return true;
                case "d":
                    DisplayChoice(choice);
                    Console.Write("Sorted Series: ");
                    DisplaySeries(Sort(series));
                    return true;
                case "e":
                    DisplayChoice(choice);
                    Console.Write("Max Value: ");
                    Console.WriteLine($"{Max(series)}\n");
                    return true;
                case "f":
                    DisplayChoice(choice);
                    Console.Write("Min Value: ");
                    Console.WriteLine($"{Min(series)}\n");
                    return true;
                case "g":
                    DisplayChoice(choice);
                    Console.Write("Average of Series: ");
                    Console.WriteLine($"{Average(series)}\n");
                    return true;
                case "h":
                    DisplayChoice(choice);
                    Console.WriteLine($"Number of Elements: {series.Length}");
                    return true;
                case "i":
                    DisplayChoice(choice);
                    Console.Write("Sum of Series: ");
                    Console.WriteLine($"{Sum(series)}\n");
                    return true;
                case "j":
                    DisplayChoice(choice);
                    Console.WriteLine("Exit.");
                    return true;
                default:
                    return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Series Analyzer!\n\n");
            string[] currentSeries = args.ToArray();
            if (currentSeries.Length == 0)
            {
                currentSeries = GetSeries();
            }
            bool toExit = false;
            while (!toExit)
            {
                bool validated = Validate(currentSeries);
                while (!validated)
                {
                    Console.WriteLine("\nCurrent series is invalid!\n");
                    currentSeries = GetSeries();
                    validated = Validate(currentSeries);
                }
                int[] intSeries = ConvertToInts(currentSeries);
                string choice = DisplayMenu(intSeries);
                bool activated = ActivateChoice(choice, intSeries);
                while (!activated)
                {
                    Console.WriteLine("Invalid input!\n");
                    Console.WriteLine("Please enter (a, b, etc.)\n");
                    choice = DisplayMenu(intSeries);
                    activated = ActivateChoice(choice, intSeries);
                }
                if (choice == "a")
                {
                    currentSeries = GetSeries();
                }
                if (choice == "j")
                {
                    toExit = true;
                }
            }
        }
    }
}
