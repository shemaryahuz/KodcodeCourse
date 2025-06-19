using SOLID.LSP.Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise2.Shapes
{
    internal class Rectangle: IRectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }
}
