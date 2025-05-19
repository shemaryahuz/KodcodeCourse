using System;

public class BankAccount
{
    private Person _Person;
    private double _Balanc;
    
    public BankAccount(Person person, double balanc)
    {
        this._Person = person;
        this._Balanc = balanc;
    }
    public void ShowBalanc()
    {
        Console.WriteLine($"Hi {this._Person.GetName()}!\n" +
            $"Your balanc is {this._Balanc}");
    }
    public void AddMoney(double amount)
    {
        this._Balanc += amount;
    }
    public void SubMoney(double amount)
    {
        this._Balanc -= amount;
    }
}