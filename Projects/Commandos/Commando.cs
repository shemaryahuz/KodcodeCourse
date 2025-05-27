using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        protected string _Name;
        public string CodeName { get; set; }
        public string[] Tools;
        public string Status;
        public Commando(string name, string codeName)
        {
            this._Name = name;
            this.CodeName = codeName;
            this.Tools = new string[] { "Hammar", "Chisel", "Rope", "bag", "Water" };
            this.Status = "Standing";
        }
        public void Walk()
        {
            Console.WriteLine($"Commando {this._Name} is Walking.");
            this.Status = "Walking";
        }
        public void Hide()
        {
            Console.WriteLine($"Commando {this._Name} is Hiding.");
            this.Status = "Hiding";
        }
        public void Attack()
        {
            Console.WriteLine($"Commando Code Name {this.CodeName} is Attacking.");
        }
        public string SayName(string commanderRank = "Turay")
        {
            if (commanderRank == "General")
            {
                return this._Name;
            }
            else if (commanderRank == "Colonel")
            {
                return this.CodeName;
            }
            return "Classified information";
        }
    }
}
