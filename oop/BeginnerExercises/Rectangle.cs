using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Rectangle
    {
        public double Width;
        public double Height;
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
