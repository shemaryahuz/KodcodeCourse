using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class ToolCategory
    {
        private string Category;
        private Tool[] tools = new Tool[2];
        public ToolCategory(string category)
        {
            this.Category = category;
            if (category == "Fastening")
            {
                this.tools[0] = new Hammer(15);
                this.tools[1] = new Tool("Glue", 1.5);
            }
            if (category == "Cutting")
            {
                this.tools[0] = new Saw(15);
                this.tools[1] = new Tool("PipeCutter", 1.5);
            }
            if (category == "Drilling")
            {
                this.tools[0] = new Drill(15);
                this.tools[1] = new Tool("Screwdriver", 1.5);
            }
        }
        public string GetCategory()
        {
            return this.Category;
        }
        public void ShowTools()
        {
            foreach (Tool tool in tools)
            {
                tool.Discribe();
            }
        }
    }
}
