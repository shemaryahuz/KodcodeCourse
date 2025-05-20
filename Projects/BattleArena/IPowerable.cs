using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal interface IPowerable
    {
        bool IsOn { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
