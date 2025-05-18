using System;

public class Student
{
    public string Name;
    public Student(string name)
    {
        this.Name = name;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {this.Name}");
    }
}