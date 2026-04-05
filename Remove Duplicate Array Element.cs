using System;

class RemoveDuplicates
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
        Console.Write("\nOriginal Array: ");
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();

        // ==============================
        //    REMOVE DUPLICATE ELEMENTS
        // ==============================
        int[] result = new int[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < count; j++)
            {
                if (arr[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                result[count] = arr[i];
                count++;
            }
        }

        // Display result array
        Console.Write("Array after Removing Duplicates: ");
        for (int i = 0; i < count; i++)
            Console.Write(result[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Total Unique Elements: " + count);
    }
}