using System;

// Extension method class must be static
static class MyExtension
{
    // Extension method
    public static int Square(this int num)
    {
        return num * num;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int number = 5;

        // Calling extension method
        int result = number.Square();

        Console.WriteLine("Square = " + result);

        Console.ReadLine();
    }
}
