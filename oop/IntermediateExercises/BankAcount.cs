using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class BankAcount
    {
        private string _Name;
        private double _Balance;
        public BankAcount(string name, double balance = 0)
        {
            this._Name = name;
            this._Balance = balance;
        }
        public void Deposit(double amount)
        {
            this._Balance += amount;
        }
        public void Withdrow(double amount)
        {
            this._Balance -= amount;
        }
        public double GetBalance()
        {
            return this._Balance;
        }
    }
}
