using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Drill: Tool
    {
        public Drill(double weight) : base("Drill", weight) { }
        public override void Discribe()
        {
            Console.WriteLine("This is a Drill!");
        }
        public override void Use()
        {
            Console.WriteLine("The Drill is drilling into the wall!");
            Console.WriteLine("test");
        }
    }
}
