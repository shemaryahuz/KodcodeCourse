using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class BattleRobot: IPowerable, IMovable, IAttackable
    {
        public bool IsOn { get; set; }
        public int Health { get; set; }
        public void TurnOn()
        {
            this.IsOn = true;
        }
        public void TurnOff()
        {
            this.IsOn = false;
        }
        public void MoveTo(string location)
        {
            if (this.IsOn)
            {
                Console.WriteLine($"Robbot is movinge to {location}.");
            }
            else
            {
                Console.WriteLine($"Robbot is off, Can't move.");
            }
            
        }
        public void Heal(int amount)
        {
            this.Health += amount;
        }
        public void TakeDamage(int amount)
        {
            Console.WriteLine($"Robbot is Taking Danage - {amount}.");
        }
    }
}
