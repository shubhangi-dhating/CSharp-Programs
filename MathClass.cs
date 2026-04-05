using System;

class MathDemo
{
    static void Main()
    {
        int a = 25, b = -10;
        double x = 2.0, y = 9.0;

        Console.WriteLine($"Abs(-10)     : {Math.Abs(b)}");
        Console.WriteLine($"Sqrt(9)      : {Math.Sqrt(y)}");
        Console.WriteLine($"Pow(2,3)     : {Math.Pow(x, 3)}");
        Console.WriteLine($"Max(25,-10)  : {Math.Max(a, b)}");
        Console.WriteLine($"Min(25,-10)  : {Math.Min(a, b)}");
        Console.WriteLine($"Round(9.67)  : {Math.Round(9.67)}");
        Console.WriteLine($"Floor(9.9)   : {Math.Floor(9.9)}");
        Console.WriteLine($"Ceiling(9.1) : {Math.Ceiling(9.1)}");
        Console.WriteLine($"Log(100)     : {Math.Log10(100)}");
        Console.WriteLine($"PI           : {Math.PI:F4}");
    }
}
