using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class Person
    {
        private string _Name;
        private int _Age;
        public Person(string name, int age)
        {
            this._Name = name;
            this._Age = age;
        }
        public string Title()
        {
            return this._Age > 17 ? "Adult" : "Minor";
        }
    }
}
