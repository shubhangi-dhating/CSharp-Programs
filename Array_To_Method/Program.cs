using System;

class Program
{
    // Method that accepts an array
    static void DisplayArray(int[] arr)
    {
        Console.WriteLine("Array elements are:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Passing array to method
        DisplayArray(numbers);
    }
}
