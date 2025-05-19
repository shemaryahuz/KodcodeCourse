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
        protected int UseCount;
        public Tool(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.UseCount = 5;
        }
        public string GetName()
        {
            return this.Name;
        }
        public double GetWeight()
        {
            return this.Weight;
        }
        public virtual void Discribe()
        {
            Console.WriteLine("This is a Tool!");
        }
        public virtual void Use()
        {
            if (UseCount < 0)
            {
                Console.WriteLine("Tool is being used.");
                this.UseCount--;
            }
            else
            {
                Console.WriteLine("Can't use!");
            }
        }
    }
}
