using Commandos.Lesson;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Encapsulation lesson
            //Animal animal = new Animal("Jony", 10, "Brown");
            //animal.MakeSound();

            //// Abstraction lesson
            //Animal animal = new Animal("Jony", 10, "Brown");
            //animal.MakeSound();
            //// Console.WriteLine(animal.Name); // Eror: Name is a private property
            //Console.WriteLine(animal);


            //// Commando testing
            //Commando commando = new("Avi", "A!x");
            //Console.WriteLine($"{commando.Name}'s Tools:");
            //foreach (string tool in commando.Tools)
            //{
            //    Console.Write($"{tool} ");
            //}
            //Console.WriteLine(".");
            //commando.Walk();
            //Console.WriteLine($"{commando.Name} Status: {commando.Status}");
            //commando.Hide();
            //Console.WriteLine($"{commando.Name} Status: {commando.Status}");
            //commando.Attack();

            // Commando testing (private properties)
            //Console.WriteLine(commando.SayName("General"));
            //Console.WriteLine(commando.SayName("Colonel"));
            //Console.WriteLine(commando.SayName("Turay"));
            //Console.WriteLine(commando.CodeName);

            //// Weapon testing
            //Weapon rifle = new("Rifle", "Uzi", 10);
            //Console.WriteLine($"{rifle.Name} has {rifle.Bullets} Bullets.");
            //for (int i = 0; i < 11; i++)
            //{
            //    rifle.Shoot();
            //}

            // Commandos inheritance
            AirCommando air = new("David", "D34");
            air.Attack();
            air.Fall();
            SeaCommando sea = new("Ben", "B@7");
            sea.Attack();
            sea.Swim();
        }
    }
}