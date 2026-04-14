using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";

        // Assigning str1 to another variable
        string str2 = str1;

        Console.WriteLine("Before modification:");
        Console.WriteLine("str1 = " + str1);
        Console.WriteLine("str2 = " + str2);

        // Modifying str1
        str1 = str1 + " World";

        Console.WriteLine("\nAfter modification:");
        Console.WriteLine("str1 = " + str1);
        Console.WriteLine("str2 = " + str2);
    }
}
