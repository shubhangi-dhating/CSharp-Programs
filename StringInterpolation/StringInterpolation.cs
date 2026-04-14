using System;

class StringInterpolation
{
    static void Main()
    {
        string name = "Rahul";
        int age = 20;
        double marks = 88.5;
        bool passed = true;

        // Basic Interpolation
        Console.WriteLine($"Name  : {name}");
        Console.WriteLine($"Age   : {age}");
        Console.WriteLine($"Marks : {marks}");
        Console.WriteLine($"Pass  : {passed}");

        // Expression inside {}
        Console.WriteLine($"\nNext Year Age : {age + 1}");
        Console.WriteLine($"Double Marks  : {marks * 2}");

        // Format specifier
        double salary = 50000.789;
        Console.WriteLine($"\nSalary         : {salary}");
        Console.WriteLine($"Salary (2 dec) : {salary:F2}");
        Console.WriteLine($"Salary (currency): {salary:C}");

        // Ternary inside {}
        Console.WriteLine($"\nResult : {(passed ? "Pass" : "Fail")}");
    }
}
