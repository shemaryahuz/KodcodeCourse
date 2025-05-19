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
            // Create tools
            Hammer hammer = new Hammer(15);
            Hammer hammer2 = new Hammer(20);
            Wrench wrench = new Wrench(10);
            Drill drill = new Drill(17.5);
            Drill drill2 = new Drill(19);
            Saw saw = new Saw(12.5);
            Saw saw2 = new Saw(11.5);
            Saw saw3 = new Saw(13.5);
            Screwdriver screwdriver = new Screwdriver(7.5);
            PipeCutter pipeCutter = new PipeCutter(9);
            // Store the tools in a List
            List<Tool> tools = new List<Tool>() {
                hammer, hammer2, wrench, drill, drill2, saw, saw2, saw3, screwdriver, pipeCutter
            };
            Tool wireStripper = new Tool("WireStripper", 2);
            Tool mailGun = new Tool("Nailgun", 8);
            tools.Add(wireStripper);
            tools.Add(mailGun);
            // Loop over the List and call methods
            foreach (Tool tool in tools)
            {
                tool.Discribe();
                tool.Use();
            }

        }
    }
}
