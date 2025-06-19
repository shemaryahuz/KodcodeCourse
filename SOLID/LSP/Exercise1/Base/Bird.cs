using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise1.Base
{
    internal class Bird
    {
        public Bird(string type)
        {
            Type = type;
        }
        public string Type { get; set; }
        public void Eat()
        {
            Console.WriteLine($"The {Type} is eating!");
        }
    }
}
