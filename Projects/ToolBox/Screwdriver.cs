using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Screwdriver: Tool
    {
        public Screwdriver(double weight) : base("Screwdriver", weight) { }
        public override void Discribe()
        {
            Console.WriteLine("This is a Screwdriver!");
        }
        public override void Use()
        {
            if (UseCount < 0)
            {
                Console.WriteLine("The Screwdriver is screwed!");
                this.UseCount--;
            }
            else
            {
                Console.WriteLine("Can't use!");
            }
        }
    }
}
