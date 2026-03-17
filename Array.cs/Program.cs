using System;

class ArrayProgram
{
    // Method to perform Linear Search
    static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    // Method to perform Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        // ===== 1D ARRAY =====
        Console.Write("Enter number of elements in 1D array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr1D = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr1D[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\n1D Array Elements:");
        foreach (int item in arr1D)
        {
            Console.Write(item + " ");
        }

        // Sorting 1D Array
        BubbleSort(arr1D);

        Console.WriteLine("\nSorted 1D Array:");
        foreach (int item in arr1D)
        {
            Console.Write(item + " ");
        }

        // Searching in 1D Array
        Console.Write("\nEnter element to search: ");
        int key = Convert.ToInt32(Console.ReadLine());

        int result = LinearSearch(arr1D, key);

        if (result != -1)
            Console.WriteLine("Element found at index: " + result);
        else
            Console.WriteLine("Element not found.");

        // ===== 2D ARRAY =====
        Console.Write("\nEnter number of rows for 2D array: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns for 2D array: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] arr2D = new int[rows, cols];

        Console.WriteLine("Enter elements for 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\n2D Array Elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr2D[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nProgram Completed.");
        Console.ReadLine();
    }
}
