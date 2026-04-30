using System;

// Delegate declaration
delegate void Message();

class Program
{
    static void Show()
    {
        Console.WriteLine("Hello from Delegate Method");
    }

    static void Main(string[] args)
    {
        // Creating delegate object
        Message msg = Show;

        // Calling method using delegate
        msg();

        Console.ReadLine();
    }
}

