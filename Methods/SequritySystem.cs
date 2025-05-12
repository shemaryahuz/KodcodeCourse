using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SequritySystem
    {
        // Sequrity System
        public static Dictionary<string, string> CreateUser()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Dictionary<string, string> user = new Dictionary<string, string>
            {
                {"name", name}
            };
            return user;
        }
        public static bool ToEnter(string username, bool isInside, int points)
        {
            if (!isInside)
            {
                if (points > 0)
                {
                    Console.WriteLine($"{username} be careful! you have bad points.");
                }
                Console.WriteLine($"Welcome {username}!");
                isInside = true;
            }
            else
            {
                Console.WriteLine($"You are already inside!\nYou got bad point.");
                points++;
            }
            return isInside;
        }
        public static bool ToExit(string username, bool isInside, int points)
        {
            if (isInside)
            {
                if (points > 0)
                {
                    Console.WriteLine($"{username} be careful! you have bad points.");
                }
                Console.WriteLine($"Bye {username}!");
                isInside = false;
            }
            else
            {
                Console.WriteLine($"You are already outside!\nYou got bad point.");
                points++;
            }
            return isInside;
        }

    }
}
