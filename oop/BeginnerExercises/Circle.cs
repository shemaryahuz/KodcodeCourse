using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Circle
    {
        public double Radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
