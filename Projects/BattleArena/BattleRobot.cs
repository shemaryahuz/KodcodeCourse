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
        void IPowerable.TurnOn()
        {
            this.IsOn = true;
        }
        void IPowerable.TurnOff()
        {
            this.IsOn = false;
        }
        void IMovable.MoveTo(string location)
        {
            Console.WriteLine($"Robbot is movinge to {location}.");
        }
        void IAttackable.Heal(int amount)
        {
            throw new NotImplementedException();
        }
        void IAttackable.TakeDamage(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
