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
        static void InputSeries()
        {

        }
        static bool Validate(string[] series)
        {
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
                "a.Input a Series. (Replace the current series)" +
                "b.Display the series in the order it was entered." +
                "c.Display the series in the reversed order it was entered." +
                "d.Display the series in sorted order(from low to high)." +
                "e.Display the Max value of the series." +
                "f.Display the Min value of the series." +
                "g.Display the Average of the series." +
                "h.Display the Number of elements in the series." +
                "i.Display the Sum of the series." +
                "j.Exit." +
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
        }
    }
}
