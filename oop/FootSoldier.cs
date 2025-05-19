using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class FootSoldier: Soldier
    {
        private string _Rifle;
        public FootSoldier(string name, string rank, int persNum, string rifle): base(name, rank, persNum)
        {
            this._Name = name;
            this._Rank = rank;
            this._PersNum = persNum;
            this._Rifle = rifle;
            this.Organization += ": FootForce";
        }
    }
}
