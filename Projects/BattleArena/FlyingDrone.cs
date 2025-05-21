using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class FlyingDrone: IPowerable, IMovable, IAttackable
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
                Console.WriteLine($"Drone is flying to {location}.");
            }
            else
            {
                Console.WriteLine($"Drone is off, Can't move.");
            }

        }
        public void TakeDamage(int amount)
        {
            Console.WriteLine($"Drone is Taking Damage - {amount}");
            this.Health -= amount;
        }
    }
}
