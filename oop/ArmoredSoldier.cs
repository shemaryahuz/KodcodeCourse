using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    internal class ArmoredSoldier: Soldier
    {
        private string _Tank;
        
        public ArmoredSoldier(string name, string rank, int persNum, string tank): base(name, rank, persNum)
        {
            this._Name = name;
            this._Rank = rank;
            this._PersNum = persNum;
            this._Tank = tank;
            this.Organization += ": ArmoredForce";
        }
        public new void Call()
        {
            Console.WriteLine("Tanks!!!");
        }
    }
}
