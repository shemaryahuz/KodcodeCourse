using Commandos.Lesson;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Commando[] commandos =
            {
                new Commando("David", "345"),
                new AirCommando("Moshe", "987"),
                new SeaCommando("Avi", "907")
            };
            foreach (Commando commando in commandos)
            {
                commando.Attack();
            }
        }
    }
}