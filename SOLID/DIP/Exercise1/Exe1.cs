using SOLID.DIP.Exercise1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Exercise1
{
    internal static class Exe1
    {
        public static void Run()
        {
            MissionController controller = new MissionController();
            controller.RunLoggers();
        }
    }
}
