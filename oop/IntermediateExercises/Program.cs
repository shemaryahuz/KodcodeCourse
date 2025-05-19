using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example for Exercise 11:
            User user = new User("Noam", "12345678");
            user.PrintUser();

            // Example for Exercise 12:
            BankAcount bankAcount = new BankAcount("Avi");
            bankAcount.Deposit(600);
            bankAcount.Withdrow(250);
            Console.WriteLine($"Balance: {bankAcount.GetBalance()}");

            // Example for Exercise 13:
            Thermostat thermostat = new Thermostat();
            thermostat.SetTemperature(25);
            thermostat.SetTemperature(30);
            thermostat.SetTemperature(10);

            // Example for Exercise 14:
            Timer timer = new Timer(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(timer.GetTime());
                timer.Decreasment();
            }

            // Example for Exercise 15:
            Person person = new Person("Moshe", 15);
            Console.WriteLine(person.Title());

            // Example for Exercise 16:
            ShopingCart cart = new ShopingCart();
            cart.AddItem("Computer", 1000);
            cart.RemoveItem("Table", 200);
            cart.RemoveItem("Computer", 1000);
            cart.AddItem("Phone", 47.99);
            Console.WriteLine($"${cart.GetTotalCost()}");
            cart.ShowCart();

            // Example for Exercise 17:
            Robot robot = new Robot();
            for (int i = 0; i < 10; i++)
            {
                robot.Move();
            }
        }
    }
}
