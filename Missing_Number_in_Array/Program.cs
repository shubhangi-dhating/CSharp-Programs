using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 }; // Missing number is 3
        int n = arr.Length + 1;

        // Sum of first n natural numbers
        int expectedSum = n * (n + 1) / 2;

        int actualSum = 0;

        foreach (int num in arr)
        {
            actualSum += num;
        }

        int missingNumber = expectedSum - actualSum;

        Console.WriteLine("Missing Number: " + missingNumber);
    }
}

