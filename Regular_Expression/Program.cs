using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Example 1: Check if string contains only digits
        if (Regex.IsMatch(input, @"^\d+$"))
        {
            Console.WriteLine("The string contains only digits.");
        }
        else
        {
            Console.WriteLine("The string does not contain only digits.");
        }

        // Example 2: Find all numbers in the string
        MatchCollection matches = Regex.Matches(input, @"\d+");

        Console.WriteLine("Numbers found in the string:");
        foreach (Match m in matches)
        {
            Console.WriteLine(m.Value);
        }
    }
}
