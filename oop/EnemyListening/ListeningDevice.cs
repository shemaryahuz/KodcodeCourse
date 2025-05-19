using System;

public class ListeningDevice
{
    public string Manufactor;
    public int BatteryValue;
    public bool IsActive;
    public string[] Speeches = new string[10];
    public int SpeechIndex;

    public ListeningDevice(string manufactor, int batteryValue = 50, bool IsActive = true)
    {
        this.Manufactor = manufactor;
        this.BatteryValue = batteryValue;
        this.IsActive = IsActive;
        this.SpeechIndex = 0;
    }

    public void Listen(string speech)
    {
        if (!this.IsActive)
        {
            Console.WriteLine("Can't listen, Device is Inactive.");
            return;
        }
        Console.WriteLine($"There is a new speech! Speech: {speech}");
        this.BatteryValue -= 5;
        this.Speeches[SpeechIndex] = speech;
        this.SpeechIndex++;
        if (this.BatteryValue == 10)
        {
            Console.WriteLine("Battery is about to run out. left 10 (two times to listen!).");
        }
            if (this.BatteryValue == 0)
        {
            this.IsActive = false;
            Console.WriteLine("Battery is Dead.");
        }
    }
}