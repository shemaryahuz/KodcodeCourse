using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Beginner
            // Example of use:
            BattleRobot bot = new BattleRobot();
            bot.MoveTo("Center");
            bot.TurnOn();
            bot.MoveTo("Center");
            bot.TakeDamage(10);
        }
    }
}
