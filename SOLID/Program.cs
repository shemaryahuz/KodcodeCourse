using SOLID.LSP.Exercise1;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            PlayBirds play = new PlayBirds();
            play.BirdsEat();
            play.BirdsFly();
        }
    }
}
