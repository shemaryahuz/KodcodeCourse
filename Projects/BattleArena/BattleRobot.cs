using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class BattleRobot: IPowerable
    {
        bool IPowerable.IsOn { get; set; }
        void IPowerable.TurnOn()
        {
            = true;
        }
        void TurnOff()
        {
            this.IsOn = false;
        }
    }
}
