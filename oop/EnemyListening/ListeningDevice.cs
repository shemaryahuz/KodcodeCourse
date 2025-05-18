using System;

public class ListeningDevice
{
    public string manufactor;
    public int batteryValue;
    public bool active;
    public string[] speeches;
    public int speechIndex;

    public ListeningDevice(string manufactor, int batteryValue = 100, bool active = true)
    {
        this.manufactor = manufactor;
        this.batteryValue = batteryValue;
        this.active = active;
        this.speechIndex = 0;
    }

    public void Listen(string speech)
    {
        if (!this.active)
        {
            Console.WriteLine("Can't listen, Device is Inactive.");
            return;
        }
        Console.WriteLine($"There is a new speech! Speech: {speech}");
        this.batteryValue -= 5;
        this.speeches[speechIndex] = speech;
        this.speechIndex++;
    }
}