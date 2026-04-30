using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating HashSet
        HashSet<int> numbers = new HashSet<int>();

        // Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20);   // Duplicate value

        // Displaying elements
        Console.WriteLine("HashSet Elements:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}

