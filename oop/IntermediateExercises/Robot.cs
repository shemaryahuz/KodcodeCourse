using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class Robot
    {
        private int _Battery = 100;
        public int GetBattery()
        {
            return this._Battery;
        }
        public void Move()
        {
            if (this._Battery > 10)
            {
                Console.WriteLine("Hi! The Robot is Moving!");
                this._Battery -= 10;
            }
            else if (this._Battery == 10)
            {
                Console.WriteLine("Low Battery!");
            }
        }
    }
}
