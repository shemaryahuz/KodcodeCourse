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
        protected int Weight;
        public Tool(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}
