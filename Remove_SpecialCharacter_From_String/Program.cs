using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        foreach (char ch in input)
        {
            // Keep only letters and digits
            if (char.IsLetterOrDigit(ch) || ch == ' ')
            {
                result += ch;
            }
        }

        Console.WriteLine("String after removing special characters:");
        Console.WriteLine(result);
    }
}

