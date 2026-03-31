using System;

class RandomNumberGenerator
{
    static Random rand = new Random();

    static void Main()
    {
        Console.WriteLine("========== Random Number Generator ==========\n");

        // 1. Basic random number (0 to 2,147,483,647)
        Console.WriteLine("1. Basic Random Number:");
        Console.WriteLine($"   {rand.Next()}\n");

        // 2. Random number in a range
        Console.WriteLine("2. Random Number between 1 and 100:");
        Console.WriteLine($"   {rand.Next(1, 101)}\n");

        // 3. Random double (0.0 to 1.0)
        Console.WriteLine("3. Random Double (0.0 - 1.0):");
        Console.WriteLine($"   {rand.NextDouble():F6}\n");

        // 4. Random double in a range
        Console.WriteLine("4. Random Double between 10.0 and 50.0:");
        double randomDouble = 10.0 + rand.NextDouble() * (50.0 - 10.0);
        Console.WriteLine($"   {randomDouble:F4}\n");

        // 5. Generate multiple random numbers
        Console.WriteLine("5. Five Random Numbers (1 - 50):");
        Console.Write("   ");
        for (int i = 0; i < 5; i++)
            Console.Write($"{rand.Next(1, 51),4}");
        Console.WriteLine("\n");

        // 6. Random even number
        Console.WriteLine("6. Random Even Number (1 - 100):");
        int even = rand.Next(1, 51) * 2;
        Console.WriteLine($"   {even}\n");

        // 7. Random odd number
        Console.WriteLine("7. Random Odd Number (1 - 99):");
        int odd = rand.Next(0, 50) * 2 + 1;
        Console.WriteLine($"   {odd}\n");

        // 8. Random boolean
        Console.WriteLine("8. Random Boolean:");
        Console.WriteLine($"   {rand.Next(2) == 0}\n");

        // 9. Random character (a-z)
        Console.WriteLine("9. Random Lowercase Letter:");
        char letter = (char)('a' + rand.Next(26));
        Console.WriteLine($"   {letter}\n");

        // 10. Random string
        Console.WriteLine("10. Random Alphanumeric String (Length 8):");
        Console.WriteLine($"    {GenerateRandomString(8)}\n");

        // 11. Shuffle an array
        Console.WriteLine("11. Shuffled Array [1..10]:");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Shuffle(arr);
        Console.WriteLine($"    [{string.Join(", ", arr)}]\n");

        // 12. Simulate dice roll
        Console.WriteLine("12. Dice Roll (1-6):");
        Console.WriteLine($"    You rolled: {rand.Next(1, 7)}\n");

        // 13. Cryptographically secure random number
        Console.WriteLine("13. Cryptographically Secure Random Number:");
        using var cRand = System.Security.Cryptography.RandomNumberGenerator.Create();
        byte[] bytes = new byte[4];
        cRand.GetBytes(bytes);
        int secureNum = Math.Abs(BitConverter.ToInt32(bytes, 0));
        Console.WriteLine($"    {secureNum}\n");

        Console.WriteLine("=============================================");
    }

    // Generate random alphanumeric string
    static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] result = new char[length];
        for (int i = 0; i < length; i++)
            result[i] = chars[rand.Next(chars.Length)];
        return new string(result);
    }

    // Fisher-Yates shuffle
    static void Shuffle(int[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
}
