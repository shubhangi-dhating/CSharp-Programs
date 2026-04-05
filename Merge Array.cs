using System;

class MergeTwoArrays
{
    static void Main(string[] args)
    {
        // Input first array
        Console.Write("Enter number of elements in Array 1: ");
        int n1 = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n1];

        Console.WriteLine("Enter " + n1 + " elements for Array 1:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write("Element [" + (i + 1) + "]: ");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        // Input second array
        Console.Write("\nEnter number of elements in Array 2: ");
        int n2 = int.Parse(Console.ReadLine());

        int[] arr2 = new int[n2];

        Console.WriteLine("Enter " + n2 + " elements for Array 2:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write("Element [" + (i + 1) + "]: ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        // ==============================
        //       MERGE TWO ARRAYS
        // ==============================
        int n3 = n1 + n2;
        int[] merged = new int[n3];

        // Copy first array
        for (int i = 0; i < n1; i++)
            merged[i] = arr1[i];

        // Copy second array
        for (int i = 0; i < n2; i++)
            merged[n1 + i] = arr2[i];

        // Display all arrays
        Console.Write("\nArray 1:       ");
        foreach (int x in arr1)
            Console.Write(x + " ");

        Console.Write("\nArray 2:       ");
        foreach (int x in arr2)
            Console.Write(x + " ");

        Console.Write("\nMerged Array:  ");
        foreach (int x in merged)
            Console.Write(x + " ");

        Console.WriteLine();
    }
}
