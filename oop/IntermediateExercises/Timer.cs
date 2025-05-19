using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class Timer
    {
        private int _Time;
        public Timer(int start)
        {
            this._Time = start;
        }
        public int GetTime()
        {
            return this._Time;
        }
        public void Decreasment()
        {
            if (this._Time > 0)
            {
                this._Time--;
            }
            if (this._Time == 0)
            {
                Console.WriteLine("Time's up!");
            }
            
        }

    }
}
