using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.EncapsulationLesson
{
    internal class Animal
    {
        public string Name;
        public int Age;
        public string Color;
        public Animal(string name, int age, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }
        public void MakeSound()
        {
            Console.WriteLine($"I'm an Animal! My Name is {this.Name}, I'm {this.Age} years old and my color is {this.Color}");
        }
    }
}
