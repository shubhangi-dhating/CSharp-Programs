using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Lambda expression to display numbers
        numbers.ForEach(n => Console.WriteLine(n));

        // Lambda expression to find even numbers
        List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);

        Console.WriteLine("\nEven Numbers:");

        evenNumbers.ForEach(n => Console.WriteLine(n));

        Console.ReadLine();
    }
}

