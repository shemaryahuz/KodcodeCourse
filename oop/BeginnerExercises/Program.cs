using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example for Exercise 1:
            Dog dog = new Dog("rocky");
            Console.WriteLine(dog.Name);
            // Example for Exercise 2:
            Car car = new Car("Toyota", 2020);
            Console.WriteLine($"{car.Brand}. {car.Year}.");
            // Example for Exercise 3:
            Student student = new Student("Maya");
            student.Introduce();
            // Example for Exercise 4:
            Book book = new Book("1984", "George Orwell");
            book.Summary();
            // Example for Exercise 5:
            Circle circle = new Circle(5);
            Console.WriteLine($"Area: {circle.Area()}");
            // Example for Exercise 6:
            Rectangle rectangle = new Rectangle(6, 9);
            Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");
            // Example for Exercise 7:
            Counter counter = new Counter();
            for (int i = 0; i < 3; i++)
            {
                counter.Increasment();
                Console.WriteLine(counter.Count);
            }
            // Example for Exercise 8:
            Movie movie = new Movie("Tintin");
            movie.ShowRate();
            movie.Rate();
            movie.ShowRate();
            // Example for Exercise 9:
            Laptop laptop = new Laptop("HP");
            laptop.Start();
            // Example for Exercise 10:
            Point point = new Point(23, 12);
            point.Move(25, 15);
        }
    }
}
