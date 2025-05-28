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
            _Name = name;
            CodeName = codeName;
            Tools = new string[] { "Hammar", "Chisel", "Rope", "bag", "Water" };
            Status = "Standing";
        }
        public void Walk()
        {
            Console.WriteLine($"Commando {_Name} is Walking.");
            Status = "Walking";
        }
        public void Hide()
        {
            Console.WriteLine($"Commando {_Name} is Hiding.");
            Status = "Hiding";
        }
        public virtual void Attack()
        {
            Console.WriteLine($"Commando Code Name {CodeName} is Attacking.");
        }
        public string SayName(string commanderRank = "Turay")
        {
            if (commanderRank == "General")
            {
                return _Name;
            }
            else if (commanderRank == "Colonel")
            {
                return CodeName;
            }
            return "Classified information";
        }
    }
}
