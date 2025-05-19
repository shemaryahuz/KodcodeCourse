using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Hammer: Tool
    {
        public Hammer(double weight) : base("Hammer", weight) { }
        public override void Discribe()
        {
            Console.WriteLine("This is a Hammer!");
        }
        public override void Use()
        {
            if (UseCount < 0)
            {
                Console.WriteLine("The Hammer is Knocking!");
                this.UseCount--;
            }
            else
            {
                Console.WriteLine("Can't use!");
            }
        }
    }
}
