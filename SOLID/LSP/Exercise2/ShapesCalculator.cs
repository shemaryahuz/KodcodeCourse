using SOLID.LSP.Exercise2.Interfaces;
using SOLID.LSP.Exercise2.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise2
{
    internal class ShapesCalculator
    {
        public ShapesCalculator()
        {
            Shapes = GetShapes();
        }
        public List<IShape> Shapes { get; set; }
        public List<IShape> GetShapes()
        {
            return new List<IShape>
            {
                new Rectangle(10, 25),
                new Rectangle(3.5, 9),
                new Square(4),
                new Square(5.33),
                new Triangular(7, 17),
                new Triangular(4, 4)
            };
        }
        public void ShowCalculations()
        {
            foreach (IShape shape in Shapes)
            {
                Console.WriteLine($"Type: {shape.GetType()}. Area: {shape.Area()}");
            }
        }
    }
}
