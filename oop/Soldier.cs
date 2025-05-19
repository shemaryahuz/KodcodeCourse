using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Soldier
    {
        protected string _Name;
        protected string _Rank;
        protected int _PersNum;
        public string Organization = "IDF";
        public Soldier(string name, string rank, int persNum)
        {
            this._Name = name;
            this._Rank = rank;
            this._PersNum = persNum;
        }
        public void Greet()
        {
            Console.WriteLine($"Hello {this._Rank} {this._Name}. Your Personal Number is: {this._PersNum}");
        }
        public void Servise()
        {
            Console.WriteLine($"You are serving in the {this.Organization}");
        }
        public virtual void Call()
        {
            Console.WriteLine("IDF!!!");
        }
    }
}
