using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Span (can modify data)
        Span<int> span = numbers;

        Console.WriteLine("Original Array:");
        foreach (var num in numbers)
            Console.Write(num + " ");
        Console.WriteLine();

        // Modify using Span
        span[1] = 99;

        Console.WriteLine("After modifying using Span:");
        foreach (var num in numbers)
            Console.Write(num + " ");
        Console.WriteLine();

        // ReadOnlySpan (cannot modify data)
        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("Reading using ReadOnlySpan:");
        foreach (var num in readOnlySpan)
            Console.Write(num + " ");
    }
}
