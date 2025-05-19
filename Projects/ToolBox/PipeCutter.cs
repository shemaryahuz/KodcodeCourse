using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class PipeCutter: Tool
    {
        public PipeCutter(double weight): base("PipeCutter", weight) {}
        public override void Discribe()
        {
            Console.WriteLine("This is a PipeCutter!");
        }
        public override void Use()
        {
            Console.WriteLine("The PipeCutter is opening the clog!");
        }
    }
}
