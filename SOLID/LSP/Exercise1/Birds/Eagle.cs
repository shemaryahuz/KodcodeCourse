using SOLID.LSP.Exercise1.Base;
using SOLID.LSP.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise1.Birds
{
    internal class Eagle: Bird, IFlying
    {
        public Eagle() : base("Eagle") { }
        public void Fly()
        {
            Console.WriteLine($"The Eagle is flying above the clouds!");
        }

    }
}
