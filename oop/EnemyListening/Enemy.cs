using System;

public class Enemy
{
    public string Name;
    public int Rank;
    public string Organization;
    public string Speech;


    public Enemy(string name, int rank, string organization)
    {
        this.Name = name;
        this.Rank = rank;
        this.Organization = organization;
    }

    public void Message()
    {
        Console.WriteLine($"Hi {this.Name}. You are from {this.Organization} Organizatiom. Your Rank is {this.Rank}.");
    }

    public void Speak(ListeningDevice device, string speech)
    {
        device.Listen(speech);
    }