using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"New position: ({this.x}, {this.y})");
        }
    }
}
