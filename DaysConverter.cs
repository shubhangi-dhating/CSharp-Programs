using System;

class DaysConverter
{
    static void Main()
    {
        Console.Write("Enter days: ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine($"Years: {d / 365}, Months: {d % 365 / 30}, Days: {d % 365 % 30}");
    }
}