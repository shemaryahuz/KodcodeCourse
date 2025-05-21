using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class GroundTrap: IPowerable
    {
        public bool IsOn { get; set; }
        public void TurnOn()
        {
            this.IsOn = true;
        }
        public void TurnOff()
        {
            this.IsOn = false;
        }
    }
}
