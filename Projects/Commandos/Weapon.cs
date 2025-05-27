using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string Name;
        public string Manufactor;
        public int Bullets;
        public Weapon(string name, string manufactor)
        {
            this.Name = name;
            this.Manufactor = manufactor;
            this.Bullets = 10;
        }
        public void Shoot()
        {
            if (this.Bullets > 0)
            {
                Console.WriteLine($"{this.Name} is shooting.");
                this.Bullets--;
            }
            else
            {
                Console.WriteLine("Bullets are gone.");
            }

        }
    }
}
