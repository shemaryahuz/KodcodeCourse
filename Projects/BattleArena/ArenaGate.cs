using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class ArenaGate: IPowerable
    {
        public bool IsOn { get; set; }
        void IPowerable.TurnOn()
        {
            this.IsOn = true;
        }
        void IPowerable.TurnOff()
        {
            this.IsOn = false;
        }
    }
}
