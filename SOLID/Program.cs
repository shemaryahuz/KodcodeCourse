using SOLID.DIP.Exercise1;
using SOLID.LSP.Exercise1;
using SOLID.LSP.Exercise2;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test for LSP.Exercise1
            PlayBirds play = new PlayBirds();
            play.BirdsEat();
            play.BirdsFly();
            // Test for LSP.Exercise2
            ShapesCalculator calculator = new ShapesCalculator();
            calculator.ShowCalculations();

            // Test for DIP.Exercise1
            Exe1.Run();
        }
    }
}
