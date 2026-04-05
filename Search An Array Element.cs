using System;

class SearchElement
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

        // Display original array
        Console.Write("\nArray Elements: ");
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();

        // Input search element
        Console.Write("\nEnter element to search: ");
        int key = int.Parse(Console.ReadLine());

        // ==============================
        //       LINEAR SEARCH
        // ==============================
        int position = -1;
        int comparisons = 0;

        for (int i = 0; i < n; i++)
        {
            comparisons++;
            if (arr[i] == key)
            {
                position = i + 1;  // 1-based position
                break;
            }
        }

        // Display Result
        Console.WriteLine("\n--- Linear Search Result ---");
        if (position != -1)
        {
            Console.WriteLine("Element " + key + " FOUND!");
            Console.WriteLine("Position   : " + position);
            Console.WriteLine("Index      : " + (position - 1));
            Console.WriteLine("Comparisons: " + comparisons);
        }
        else
        {
            Console.WriteLine("Element " + key + " NOT FOUND!");
            Console.WriteLine("Comparisons: " + comparisons);
        }
    }
}
