using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Exercises
    {
        // Exercise 1
        public static bool IsValidAge(int age)
        {
            return age > 17 && age < 66 ? true : false;
        }

        // Exercise 2
        public static string FormatName(string firstName, string lastName)
        {
            return firstName != "" && lastName != "" ? $"{lastName}, {firstName}" : "Invalid input!";
        }

        // Exercise 3
        public static bool IsStrongPassword(string passwowd)
        {
            if (passwowd.Length < 8)
            {
                return false;
            }
            bool hasDigit = false;
            bool hasUpper = false;
            foreach (char chr in passwowd)
            {
                if (char.IsDigit(chr))
                {
                    hasDigit = true;
                }
                else if (char.IsUpper(chr))
                {
                    hasUpper = true;
                }
                if (hasDigit && hasUpper)
                {
                    return true;
                }
            }
            return false;
        }

        // Exercise 4
        public static int SumEvens(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        // Exercise 5
        public static string GetLongestWord(List<string> words)
        {
            string longest = words[0];
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            return longest;
        }
        public static void Main()
        {
            // Example for Exercise 1: IsValidAge
            bool isValid = Exercises.IsValidAge(25);
            Console.WriteLine($"Is 25 a valid age? {isValid}");

            // Example for Exercise 2: FormatName
            string formattedName = Exercises.FormatName("John", "Doe");
            Console.WriteLine($"Formatted Name: {formattedName}");

            // Example for Exercise 3: IsStrongPassword
            bool isStrong = Exercises.IsStrongPassword("Password1");
            Console.WriteLine($"Is 'Password1' strong? {isStrong}");

            // Example for Exercise 4: SumEvens
            int sum = Exercises.SumEvens(new int[] { 1, 2, 3, 4 });
            Console.WriteLine($"Sum of evens: {sum}");

            // Example for Exercise 5: GetLongestWord
            string longestWord = Exercises.GetLongestWord(new List<string> { "apple", "banana", "cherry" });
            Console.WriteLine($"Longest word: {longestWord}");
        }
    }
}
