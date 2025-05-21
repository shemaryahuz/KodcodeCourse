using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class MedicStation: IHealer
    {
        public int Health { get; set; }
        public void Heal(int amount)
        {
            Console.WriteLine($"Megic Station is Healing - {amount}");
            this.Health -= amount;
        }
    }
}
