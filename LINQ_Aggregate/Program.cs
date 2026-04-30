using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Aggregate: sum of all elements
        int sum = numbers.Aggregate((total, n) => total + n);

        // Aggregate: multiplication of all elements
        int product = numbers.Aggregate((total, n) => total * n);

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Product = " + product);

        Console.ReadLine();
    }
}

