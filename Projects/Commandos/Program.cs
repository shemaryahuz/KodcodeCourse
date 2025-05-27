using Commandos.EncapsulationLesson;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Jony", 10, "Brown");
            animal.MakeSound();
        }
    }
}