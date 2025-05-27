using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string Name;
        public string CodeName;
        public string[] Tools;
        public string Status;
        public Commando(string name, string codeName)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Tools = new string[] { "Hammar", "Chisel", "Rope", "bag", "Water" };
            this.Status = "Standing";
        }
        public void Walk()
        {
            Console.WriteLine($"Commando {this.Name} is Walking.");
            this.Status = "Walking";
        }
        public void Hide()
        {
            Console.WriteLine($"Commando {this.Name} is Hiding.");
            this.Status = "Hiding";
        }
        public void Attack()
        {
            Console.WriteLine($"Commando Code Name {this.CodeName} is Attacking.");
        }
    }
}
