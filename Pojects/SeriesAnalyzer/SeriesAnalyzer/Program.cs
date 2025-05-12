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
            Console.WriteLine("Please enter series of numbers (at least 3 positive numbers saperated by space):");
            string[] series = Console.ReadLine().Split(' ');
            return series;
        }
        static bool Validate(string[] series)
        {
            if (series.Length < 3)
            {
                return false;
            }
            foreach (string str in series)
            {
                foreach (char chr in str)
                {
                    if (!char.IsDigit(chr))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Display(string[] series)
        {

        }
        static string[] Reverse(string[] series)
        {
            return series;
        }
        static string[] Sort(string[] series)
        {
            return series;
        }
        static string Max(string[] series)
        {
            return series[0];
        }
        static string Min(string[] series)
        {
            return series[0];
        }
        static string Average(string[] series)
        {
            return series[0];
        }
        static int Count(string[] series)
        {
            return 0;
        }
        static string Sum(string[] series)
        {
            return series[0];
        }
        static string DisplayMenu()
        {
            Console.WriteLine(
                "Menu: " +
                "a.Input a Series. (Replace the current series)\n" +
                "b.Display the series in the order it was entered.\n" +
                "c.Display the series in the reversed order it was entered.\n" +
                "d.Display the series in sorted order(from low to high).\n" +
                "e.Display the Max value of the series.\n" +
                "f.Display the Min value of the series.\n" +
                "g.Display the Average of the series.\n" +
                "h.Display the Number of elements in the series.\n" +
                "i.Display the Sum of the series.\n" +
                "j.Exit.\n" +
                "Please enter your choice (a, b, etc.):"
                );
            string choice = Console.ReadLine();
            while (
                choice != "a"
                && choice != "b"
                && choice != "c"
                && choice != "d"
                && choice != "e"
                && choice != "f"
                && choice != "g"
                && choice != "h" 
                && choice != "i"
                && choice != "j"
                )
            {
                Console.WriteLine("Invalid input! Please enter your choice (a, b, etc.):");
                choice = Console.ReadLine();
            }
            return choice;
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
