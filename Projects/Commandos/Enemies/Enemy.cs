using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Life { get; set; }
        public bool IsAlive { get; set; }
        public Enemy(string name)
        {
            this.Name = name;
            this.Life = 100;
            this.IsAlive = true;
        }
        public void Shout()
        {
            Console.WriteLine($"My name is {this.Name} and I'M an enemy!");
        }
    }
}
