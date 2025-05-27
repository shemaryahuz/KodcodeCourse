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
        public Weapon(string name, string manufactor, int bullets)
        {
            this.Name = name;
            this.Manufactor = manufactor;
            this.Bullets = bullets;
        }
        public void Shoot()
        {
            if (this.Bullets > 0)
            {
                Console.WriteLine($"{this.Name} from {this.Manufactor} is shooting.");
                this.Bullets--;
            }
            else
            {
                Console.WriteLine("Bullets are gone.");
            }

        }
    }
}
