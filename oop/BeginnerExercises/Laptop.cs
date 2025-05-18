using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Laptop
    {
        public string Model;
        public Laptop(string model)
        {
            this.Model = model;
        }
        public void Start()
        {
            Console.WriteLine($"{this.Model} is Booting...");
        }
    }
}
