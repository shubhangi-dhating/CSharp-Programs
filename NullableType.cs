using System;

class NullableTypes
{
    static void Main()
    {
        // Nullable int
        int? age = null;
        Console.WriteLine($"Age: {age}");        // Output: Age:
        Console.WriteLine($"HasValue: {age.HasValue}"); // Output: False

        age = 25;
        Console.WriteLine($"Age: {age}");        // Output: Age: 25
        Console.WriteLine($"HasValue: {age.HasValue}"); // Output: True

        // Nullable double
        double? salary = null;
        salary = 50000.50;
        Console.WriteLine($"Salary: {salary}");  // Output: Salary: 50000.5

        // Nullable bool
        bool? isActive = null;
        Console.WriteLine($"IsActive: {isActive}"); // Output: IsActive:

        isActive = true;
        Console.WriteLine($"IsActive: {isActive}"); // Output: IsActive: True

        // GetValueOrDefault
        int? marks = null;
        Console.WriteLine($"Marks: {marks.GetValueOrDefault()}");  // Output: 0

        // ?? (Null Coalescing Operator)
        int? score = null;
        int result = score ?? 100;
        Console.WriteLine($"Score: {result}");   // Output: Score: 100
    }
}
