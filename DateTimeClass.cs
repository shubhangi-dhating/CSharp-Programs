using System;

class DateTimeDemo
{
    static void Main()
    {
        // Current Date & Time
        DateTime now = DateTime.Now;
        Console.WriteLine($"Now          : {now}");
        Console.WriteLine($"Date         : {now.Date.ToShortDateString()}");
        Console.WriteLine($"Time         : {now.TimeOfDay}");

        // Properties
        Console.WriteLine($"\nYear         : {now.Year}");
        Console.WriteLine($"Month        : {now.Month}");
        Console.WriteLine($"Day          : {now.Day}");
        Console.WriteLine($"Hour         : {now.Hour}");
        Console.WriteLine($"Minute       : {now.Minute}");
        Console.WriteLine($"Day of Week  : {now.DayOfWeek}");

        // Add / Subtract
        Console.WriteLine($"\nAfter 10 Days  : {now.AddDays(10).ToShortDateString()}");
        Console.WriteLine($"Before 10 Days : {now.AddDays(-10).ToShortDateString()}");
        Console.WriteLine($"After 2 Months : {now.AddMonths(2).ToShortDateString()}");

        // Format
        Console.WriteLine($"\nFormat 1 : {now:dd-MM-yyyy}");
        Console.WriteLine($"Format 2 : {now:MM/dd/yyyy}");
        Console.WriteLine($"Format 3 : {now:dddd, MMMM dd yyyy}");
        Console.WriteLine($"Format 4 : {now:hh:mm:ss tt}");
    }
}
