using System;

class EnumDemo
{
    // Define Enum
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    enum Season { Spring = 1, Summer = 2, Autumn = 3, Winter = 4 }

    static void Main()
    {
        // Basic Enum
        Day today = Day.Wed;
        Console.WriteLine($"Today : {today}");
        Console.WriteLine($"Value : {(int)today}");

        // Enum with values
        Season s = Season.Winter;
        Console.WriteLine($"\nSeason : {s}");
        Console.WriteLine($"Value  : {(int)s}");

        // Enum in switch
        Day d = Day.Sat;
        switch (d)
        {
            case Day.Sat:
            case Day.Sun:
                Console.WriteLine($"\n{d} is a Weekend!");
                break;
            default:
                Console.WriteLine($"\n{d} is a Weekday!");
                break;
        }
    }
}
