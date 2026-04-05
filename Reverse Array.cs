using System;

class ReverseArray
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

        Console.Write("\nOriginal Array: ");
        foreach (int x in arr)
            Console.Write(x + " ");

        // Built-in Reverse
        Array.Reverse(arr);

        Console.Write("\nReversed Array: ");
        foreach (int x in arr)
            Console.Write(x + " ");

        Console.WriteLine();
    }
}
