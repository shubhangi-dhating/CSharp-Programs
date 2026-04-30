using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        // Where: filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        // Select: square each number
        var squares = numbers.Select(n => n * n);

        Console.WriteLine("Even Numbers:");
        foreach (int n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nSquares:");
        foreach (int n in squares)
        {
            Console.WriteLine(n);
        }

        Console.ReadLine();
    }
}

