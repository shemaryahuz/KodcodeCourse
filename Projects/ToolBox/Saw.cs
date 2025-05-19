using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Saw: Tool
    {
        public Saw(double weight) : base("Saw", weight) { }
        public override void Discribe()
        {
            Console.WriteLine("This is a Saw!");
        }
        public override void Use()
        {
            Console.WriteLine("The Saw is sawing!");
        }
    }
}
