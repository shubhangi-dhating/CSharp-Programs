using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating List
        List<string> names = new List<string>();

        // Adding elements
        names.Add("Rahul");
        names.Add("Amit");
        names.Add("Sneha");
        names.Add("Priya");

        // Displaying elements
        Console.WriteLine("List Elements:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();
    }
}

