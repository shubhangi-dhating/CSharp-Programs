using System;

class Program
{
    // Method using params keyword
    static int AddNumbers(params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Sum of 2 numbers: " + AddNumbers(10, 20));
        Console.WriteLine("Sum of 4 numbers: " + AddNumbers(1, 2, 3, 4));
        Console.WriteLine("Sum of no numbers: " + AddNumbers());
    }
}
