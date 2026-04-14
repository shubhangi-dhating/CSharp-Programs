using System;

class Program
{
    static void Main()
    {
        // Declaring and initializing 2D array
        int[,] arr = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        Console.WriteLine("Multidimensional Array Elements:");

        // Traversing the array
        for (int i = 0; i < arr.GetLength(0); i++) // rows
        {
            for (int j = 0; j < arr.GetLength(1); j++) // columns
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
