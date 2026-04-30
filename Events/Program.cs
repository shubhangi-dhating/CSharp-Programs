using System;

// Delegate for event
delegate void Notify();

// Publisher class
class Alarm
{
    public event Notify Ring;

    public void StartAlarm()
    {
        Console.WriteLine("Alarm is ringing...");

        // Raise event
        if (Ring != null)
        {
            Ring();
        }
    }
}

// Subscriber class
class Program
{
    static void Message()
    {
        Console.WriteLine("Wake up! Time to get up.");
    }

    static void Main(string[] args)
    {
        Alarm a1 = new Alarm();

        // Subscribe to event
        a1.Ring += Message;

        // Trigger event
        a1.StartAlarm();

        Console.ReadLine();
    }
}


