using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class User
    {
        private string _Username;
        private string _Password;
        public User(string username, string password)
        {
            this._Username = username;
            this._Password = password;
        }
        public void SetUsername(string username)
        {
            this._Username = username;
        }
        public string GetUsername(string username)
        {
            return this._Username;
        }
        public void SetPassword(string password)
        {
            this._Password = password;
        }
        public string GetPassword(string password)
        {
            return this._Username;
        }
        public void PrintUser()
        {
            Console.Write(
                $"Username: {this._Username}.\n" +
                $"Password:");
            for (int i = 0; i < this._Password.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
