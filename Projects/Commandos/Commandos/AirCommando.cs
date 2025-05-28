
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando: Commando
    {
        public AirCommando(string name, string codeName):base(name, codeName) { }
        public void Fall()
        {
            Console.WriteLine($"{this._Name} is Falling");
        }
        public override void Attack()
        {
            Console.WriteLine($"AirCommando Code Name {this.CodeName} is Attacking.");
        }
    }
}
