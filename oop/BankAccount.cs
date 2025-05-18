using System;

public class BankAccount
{
    Person person;
    double balanc;
    
    public BankAccount(Person person, double balanc)
    {
        this.person = person;
        this.balanc = balanc;
    }
    public void ShowBalanc()
    {
        Console.WriteLine($"Hi {this.person.name}!\n" +
            $"Your balanc is {this.balanc}");
    }
    public void AddMoney(double amount)
    {
        this.balanc += amount;
    }
    public void SubMoney(double amount)
    {
        this.balanc -= amount;
    }
}