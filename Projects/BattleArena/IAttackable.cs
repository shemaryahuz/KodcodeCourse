using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal interface IAttackable
    {
        int Health { get; set; }
        void TakeDamage(int amount);
        void Heal(int amount);
    }
}
