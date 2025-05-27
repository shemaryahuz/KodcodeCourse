using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando: Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }
        public void Swim()
        {
            Console.WriteLine($"{this._Name} is Swiming");
        }
    }
}
