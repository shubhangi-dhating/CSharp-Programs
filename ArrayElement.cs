using System;

class ArrayDemo
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        // Read
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Display
        Console.WriteLine("\nArray Elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}
