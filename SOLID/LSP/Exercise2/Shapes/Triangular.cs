using SOLID.LSP.Exercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise2.Shapes
{
    internal class Triangular: IShape
    {
        public Triangular(double tHeight, double tBase)
        {
            Height = tHeight;
            Base = tBase;
        }
        public double Height { get; set; }
        public double Base { get; set; }
        public double Area()
        {
            return Height * Base / 2;
        }
    }
}
