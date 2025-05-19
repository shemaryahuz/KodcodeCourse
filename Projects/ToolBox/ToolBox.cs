using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class ToolBox
    {
        private List<Tool> Tools = new List<Tool>();

        public List<Tool> GetTools()
        {
            return this.Tools;
        }
        public void AddTool(Tool tool)
        {
            this.Tools.Add(tool);
        }
        public void ShowTools()
        {
            Console.WriteLine("Tool Box Summery:");
            foreach (Tool tool in this.Tools)
            {
                Console.Write("Name: ");
                Console.Write($"{tool.GetName()}. ");
                Console.Write("Weight: ");
                Console.WriteLine($"{tool.GetWeight()}. ");
            }
        }
    }
}
