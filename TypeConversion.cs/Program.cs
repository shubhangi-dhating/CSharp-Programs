using System;

class TypeCastingDemo
{
    static void Main()
    {
        // Implicit Casting (smaller to larger type)
        int num = 100;
        double implicitCast = num;   // int to double

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine("Integer value: " + num);
        Console.WriteLine("Converted to double: " + implicitCast);

        Console.WriteLine();

        // Explicit Casting (larger to smaller type)
        double number = 123.45;
        int explicitCast = (int)number;   // double to int

        Console.WriteLine("Explicit Casting:");
        Console.WriteLine("Double value: " + number);
        Console.WriteLine("Converted to int: " + explicitCast);

        Console.ReadLine();
    }
}
