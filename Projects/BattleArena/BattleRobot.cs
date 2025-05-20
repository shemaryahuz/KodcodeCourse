using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class BattleRobot: IPowerable
    {
        bool IsOn { get; set; }
        void TurnOn()
        {
            this.IsOn = true;
        }
        void TurnOff()
        {
            this.IsOn = false;
        }
    }
}
