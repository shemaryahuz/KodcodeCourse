using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tool> tools = new List<Tool>();
            Hammer hammer = new Hammer(15);
            Hammer hammer2 = new Hammer(20);
            tools.Add(hammer);
            tools.Add(hammer2);
            Wrench wrench = new Wrench(10);
            tools.Add(wrench);
            Drill drill = new Drill(17.5);
            Drill drill2 = new Drill(19);
            tools.Add(drill);
            tools.Add(drill2);
            Saw saw = new Saw(12.5);
            Saw saw2 = new Saw(11.5);
            Saw saw3 = new Saw(13.5);
            tools.Add(saw);
            tools.Add(saw2);
            tools.Add(saw3);
            Screwdriver screwdriver = new Screwdriver(7.5);
            tools.Add(screwdriver);
            PipeCutter pipeCutter = new PipeCutter(9);
            tools.Add(pipeCutter);
        }
    }
}
