using System;

class SumAndAverage
{
    static void Main(string[] args)
    {
        // Input array size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // Input array elements
        Console.WriteLine("Enter " + n + " elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [" + (i + 1) + "]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Calculate Sum
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        // Calculate Average
        double average = (double)sum / n;

        // Output
        Console.WriteLine("\n--- Result ---");
        Console.Write("Array Elements: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Sum     = " + sum);
        Console.WriteLine("Average = " + average);
    }
}
