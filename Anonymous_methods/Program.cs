using System;

// Delegate declaration
delegate void Message(string name);

class Program
{
    static void Main(string[] args)
    {
        // Anonymous method assigned to delegate
        Message msg = delegate(string name)
        {
            Console.WriteLine("Hello " + name);
        };

        // Calling anonymous method
        msg("Rahul");

        Console.ReadLine();
    }
}
