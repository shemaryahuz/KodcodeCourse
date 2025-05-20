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
        void TornOn()
        {
            this.IsOn = true;
        }
        void TornOff()
        {
            this.IsOn = false;
        }
    }
}
