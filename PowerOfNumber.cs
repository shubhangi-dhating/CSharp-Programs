using System;

class PowerOfNumber
{
    static void Main()
    {
        Console.WriteLine("========== Power of Number Program ==========\n");

        // 1. Using Math.Pow()
        Console.WriteLine("1. Using Math.Pow():");
        double baseNum = 2, exponent = 10;
        double result = Math.Pow(baseNum, exponent);
        Console.WriteLine($"   {baseNum}^{exponent} = {result}\n");

        // 2. Using a loop
        Console.WriteLine("2. Using a Loop:");
        Console.WriteLine($"   {Power_Loop(3, 4)} (3^4)\n");

        // 3. Using recursion
        Console.WriteLine("3. Using Recursion:");
        Console.WriteLine($"   {Power_Recursive(5, 3)} (5^3)\n");

        // 4. Fast Exponentiation (Binary Exponentiation)
        Console.WriteLine("4. Fast Exponentiation:");
        Console.WriteLine($"   {Power_Fast(2, 10)} (2^10)\n");

        // 5. Negative exponent
        Console.WriteLine("5. Negative Exponent:");
        Console.WriteLine($"   2^-3 = {Math.Pow(2, -3):F6}\n");

        // 6. Fractional exponent (square root, cube root)
        Console.WriteLine("6. Fractional Exponent:");
        Console.WriteLine($"   16^0.5 = {Math.Pow(16, 0.5)} (Square Root)");
        Console.WriteLine($"   27^(1/3) = {Math.Pow(27, 1.0 / 3):F4} (Cube Root)\n");

        // 7. Power of 0 and 1 edge cases
        Console.WriteLine("7. Edge Cases:");
        Console.WriteLine($"   Any number ^ 0 = {Math.Pow(999, 0)}");
        Console.WriteLine($"   0 ^ Any number  = {Math.Pow(0, 5)}");
        Console.WriteLine($"   1 ^ Any number  = {Math.Pow(1, 999)}");
        Console.WriteLine($"   0 ^ 0           = {Math.Pow(0, 0)}\n");

        // 8. Power table
        Console.WriteLine("8. Power Table (base 2 to 5, exp 1 to 5):");
        Console.Write($"   {"Base",-6}");
        for (int e = 1; e <= 5; e++)
            Console.Write($"  ^{e,4}");
        Console.WriteLine();
        Console.WriteLine("   " + new string('-', 36));
        for (int b = 2; b <= 5; b++)
        {
            Console.Write($"   {b,-6}");
            for (int e = 1; e <= 5; e++)
                Console.Write($"  {Math.Pow(b, e),5}");
            Console.WriteLine();
        }

        // 9. User input
        Console.WriteLine("\n9. Custom Input:");
        Console.Write("   Enter base number  : ");
        if (double.TryParse(Console.ReadLine(), out double userBase))
        {
            Console.Write("   Enter exponent     : ");
            if (double.TryParse(Console.ReadLine(), out double userExp))
            {
                Console.WriteLine($"   Result: {userBase}^{userExp} = {Math.Pow(userBase, userExp):F4}");
            }
            else Console.WriteLine("   Invalid exponent.");
        }
        else Console.WriteLine("   Invalid base.");

        Console.WriteLine("\n=============================================");
    }

    // Method 1: Loop-based power
    static long Power_Loop(long baseNum, int exp)
    {
        long result = 1;
        for (int i = 0; i < exp; i++)
            result *= baseNum;
        return result;
    }

    // Method 2: Recursive power
    static long Power_Recursive(long baseNum, int exp)
    {
        if (exp == 0) return 1;
        if (exp == 1) return baseNum;
        return baseNum * Power_Recursive(baseNum, exp - 1);
    }

    // Method 3: Fast Exponentiation (O log n)
    static long Power_Fast(long baseNum, int exp)
    {
        long result = 1;
        while (exp > 0)
        {
            if (exp % 2 == 1)       // If exponent is odd
                result *= baseNum;
            baseNum *= baseNum;     // Square the base
            exp /= 2;               // Halve the exponent
        }
        return result;
    }
}


