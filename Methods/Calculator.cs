using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Calculator
    {
        public static void WelcomeMassege()
        {
            Console.WriteLine("Welcome to my calculator!\n You will be asked to enter 2 numbers and operator\nthen you will see result");
        }
        public static double GetNumber()
        {
            Console.WriteLine("Enter number:");
            double num;
            bool valid = double.TryParse(Console.ReadLine(), out num);
            while (!valid)
            {
                Console.WriteLine("Invalid input! Enter a number:");
                valid = double.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
        public static string GetOperator()
        {
            Console.WriteLine("Enter operator (+, -, *, /):");
            string oper = Console.ReadLine();
            while (oper != "+" && oper != "-" && oper != "*" && oper != "/")
            {
                Console.WriteLine("Invalid input! Enter operator (+, -, *, /):");
                oper = Console.ReadLine();
            }
            return oper;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Substract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x + y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static double Calculate(double x, double y, string oper)
        {
            switch (oper)
            {
                case "+":
                    return Add(x, y);
                case "-":
                    return Substract(x, y);
                case "*":
                    return Multiply(x, y);
                case "/":
                    while (y == 0)
                    {
                        Console.WriteLine("Can't divide by 0!");
                        y = GetNumber();
                    }
                    return Divide(x, y);
                default:
                    return 0;
            }
        }
        public static void DisplayResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
        public static void Main()
        {
            WelcomeMassege();
            double num1 = GetNumber();
            double num2 = GetNumber();
            string oper = GetOperator();
            double result = Calculate(num1, num2, oper);
            DisplayResult(result);
        }
    }
}
