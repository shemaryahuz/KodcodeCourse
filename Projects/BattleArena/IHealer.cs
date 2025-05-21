using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal interface IHealer
    {
        int Health { get; set; }
        void Heal(int amount);
    }
}
