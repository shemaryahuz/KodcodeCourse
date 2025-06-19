using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise2.Interfaces
{
    internal interface IRectangle: IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
