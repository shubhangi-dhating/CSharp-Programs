using System;
using System.Threading;

class Program
{
    static void ShowNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Child Thread: " + i);
            Thread.Sleep(500);
        }
    }

    static void Main(string[] args)
    {
        // Create thread
        Thread t1 = new Thread(ShowNumbers);

        // Start thread
        t1.Start();

        // Main thread work
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(500);
        }

        Console.ReadLine();
    }
}

