using System;

// Delegate declaration
delegate void Message();

class Program
{
    static void Show1()
    {
        Console.WriteLine("First Method Called");
    }

    static void Show2()
    {
        Console.WriteLine("Second Method Called");
    }

    static void Main(string[] args)
    {
        // Creating multicast delegate
        Message msg = Show1;
        msg += Show2;

        // Calling both methods
        msg();

        Console.ReadLine();
    }
}
