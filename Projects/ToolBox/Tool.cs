using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Tool
    {
        protected string Name;
        protected int Weight;
        public Tool(string name, int wheight)
        {
            this.Name = name;
            this.Weight = wheight;
        }
        public void Describe()
        {
            Console.WriteLine("This is a Tool!");
        }
        public void Use()
        {
            Console.WriteLine("Tool is being used.");
        }
    }
}
