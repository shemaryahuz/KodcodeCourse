using System;

public class Person
{
    public string name;
    public int age;
    public int id;

    public Person(string name, int age, int id)
    {
        this.name = name;
        this.age = age;
        this.id = id;
    }
    public void Greet()
    {
        Console.WriteLine($"Hello {this.name}!\n" +
            $"Your {this.age} years old.\n" +
            $"Your id is: {this.id}");
    }
}