using System;
using System.Linq;

class LargestSmallest
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter " + n + " elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [" + (i + 1) + "]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Using LINQ
        int largest = arr.Max();
        int smallest = arr.Min();

        Console.WriteLine("\nLargest  Element = " + largest);
        Console.WriteLine("Smallest Element = " + smallest);
    }
}
