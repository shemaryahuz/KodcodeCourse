using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Wrench: Tool
    {
        public Wrench(double weight) : base("Wrench", weight) { }
        public override void Discribe()
        {
            Console.WriteLine("This is a Wrench!");
        }
        public override void Use()
        {
            Console.WriteLine("The Screws are opened using the Wrench!");
        }
    }
}
