using System;
using System.Diagnostics.Metrics;

class LeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine($"{year} is a Leap Year.");
        else
            Console.WriteLine($"{year} is NOT a Leap Year.");
    }
}
