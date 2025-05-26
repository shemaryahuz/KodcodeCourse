using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    internal static class MenuManager
    {
        public static void ShowMenu()
        {
            Console.WriteLine(
                "ATBASH CHIPER MENU\n" +
                "1. Write a message for encryption.\n" +
                "2. Save the encrypted message in a file.\n" +
                "3. Read the encrypted message from the file.\n" +
                "4. Decrypt and show the message.\n" +
                "5. Exit."
                );
        }
        public static string GetChoice()
        {
            return Console.ReadLine();
        }
        public static bool Validate(string choic)
        {
            string[] validCoices = { "1", "2", "3", "4", "5"};
            return validCoices.Contains(choic);
        }
        public static string GetMessage()
        {
            return Console.ReadLine();
        }
        public static ActivateChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    MenuManager.GetMessage();

            }
        }
    }
}
