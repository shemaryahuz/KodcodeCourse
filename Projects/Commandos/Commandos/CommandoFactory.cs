using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class CommandoFactory
    {
        private static CommandoFactory _Instance;
        private CommandoFactory() { }
        public static CommandoFactory GetInstance()
        {
            if (_Instance is null)
            {
                _Instance = new CommandoFactory();
            }
            return _Instance;
        }
        public List<Commando> Commandos { get; set; } = new List<Commando>();
        public void AddCommando(string name, string codeName, string type = "Commando")
        {
            switch (type)
            {
                case "SeaCommando":
                    Commandos.Add(new SeaCommando(name, codeName));
                    break;
                case "AirCommando":
                    Commandos.Add(new AirCommando(name, codeName));
                    break;
                default:
                    Commandos.Add(new Commando(name, codeName));
                    break;
            }
        }
    }
}
