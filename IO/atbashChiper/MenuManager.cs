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
                "1. Write a message for encryption and Save the encrypted message in a file.\n" +
                "2. Decrypt and show the message.\n" +
                "3. Exit."
                );
        }
        public static string GetChoice()
        {
            return Console.ReadLine();
        }
        public static bool Validate(string choic)
        {
            string[] validCoices = { "1", "2", "3"};
            return validCoices.Contains(choic);
        }
        public static string GetMessage()
        {
            Console.WriteLine("Enter message for encryption:");
            return Console.ReadLine();
        }
        public static void ActivateChoice(string choice, AtbashArrays atbashArrays)
        {
            switch (choice)
            {
                case "1":

                    string message = MenuManager.GetMessage();
                    string encrypted = Encryptor.Encrypt(message, atbashArrays);
                    FileManager.Save(encrypted);
                    Console.WriteLine($"Your message: '{message}' was encryepted to '{encrypted}' and saved in a file.");
                    break;
                case "2":
                    string readed = FileManager.Read();
                    string decrypted = Decryptor.Decrypt(readed, atbashArrays);
                    Console.WriteLine($"The encrypted message '{readed}' decrypted to '{decrypted}'");
                    break;


            }
        }
    }
}
