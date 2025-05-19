using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Book
    {
        public string Title;
        public string Author;
        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
        public void Summary()
        {
            Console.WriteLine($"'{this.Title}' by {this.Author}");
        }
    }
}
