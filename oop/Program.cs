using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("jhon", 25, 987087632);
            person.Greet();
            BankAccount bankAccount = new BankAccount(person, 1000);
            bankAccount.AddMoney(300);
            bankAccount.SubMoney(200);
            bankAccount.ShowBalanc();
        }
    }
}
