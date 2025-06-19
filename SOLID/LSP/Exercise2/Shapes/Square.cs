using SOLID.LSP.Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise2.Shapes
{
    internal class Square: IRectangle
    {
        public Square(double width)
        {
            Height = width;
            Width = width;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }
}
