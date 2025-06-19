using SOLID.LSP.Exercise1.Birds;
using SOLID.LSP.Exercise1.Base;
using SOLID.LSP.Exercise1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Exercise1
{
    internal class PlayBirds
    {
        public PlayBirds()
        {
            Birds = new List<Bird>
            {
                new Eagle(),
                new Crow(),
                new Penguin()
            };
            Flyings = new List<IFlying>();
            foreach (Bird bird in Birds)
            {
                if (bird is IFlying flying)
                {
                    Flyings.Add(flying);
                }
            }
        }
        public List<Bird> Birds { get; set; }
        public List<IFlying> Flyings { get; set; }
        public void BirdsEat()
        {
            foreach (Bird bird in Birds)
            {
                bird.Eat();
            }
        }
        public void BirdsFly()
        {
            foreach(IFlying flying in Flyings)
            {
                flying.Fly();
            }
        }
    }
}
