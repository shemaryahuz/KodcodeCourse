using System;

public class Person
{
    private string _Name { get; set; }
    private int _Age { get; set; }
    private int _ID { get; set; }

    public Person(string name, int age, int id)
    {
        this._Name = name;
        this._Age = age;
        this._ID = id;
    }
    public string GetName()
    {
        return this._Name;
    }
    public int GetAge()
    {
        return this._Age;
    }
    public int GetID()
    {
        return this._ID;
    }
    public void Greet()
    {
        Console.WriteLine($"Hello {this._Name}!\n" +
            $"Your {this._Age} years old.\n" +
            $"Your id is: {this._ID}");
    }
}