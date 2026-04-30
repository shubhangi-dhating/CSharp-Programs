using System;

// Static class
static class Demo
{
    public static int number = 100;

    public static void Show()
    {
        Console.WriteLine("Static Method Called");
        Console.WriteLine("Number = " + number);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Accessing static members using class name
        Demo.Show();

        Console.ReadLine();
    }
}
