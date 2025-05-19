using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Tool
    {
        protected string Name;
        protected double Weight;
        public Tool(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public virtual void Discribe()
        {
            Console.WriteLine("This is a Tool!");
        }
        public virtual void Use()
        {
            Console.WriteLine("Tool is being used.");
        }
    }
}
