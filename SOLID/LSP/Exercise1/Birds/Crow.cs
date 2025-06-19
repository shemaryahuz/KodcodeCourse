using SOLID.LSP.Exercise1.Base;
using SOLID.LSP.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise1.Birds
{
    internal class Crow: Bird, IFlying
    {
        public Crow() : base("Crow") { }
        public void Fly()
        {
            Console.WriteLine("The Crow is flying in the neighborhood!");
        }
    }
}
