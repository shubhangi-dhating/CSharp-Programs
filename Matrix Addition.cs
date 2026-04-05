using System;

class MatrixAddition
{
    static void Main(string[] args)
    {
        // Input matrix dimensions
        Console.Write("Enter number of Rows:    ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of Columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] mat1 = new int[rows, cols];
        int[,] mat2 = new int[rows, cols];
        int[,] result = new int[rows, cols];

        // Input Matrix 1
        Console.WriteLine("\nEnter elements of Matrix 1:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write("mat1[" + (i + 1) + "][" + (j + 1) + "]: ");
                mat1[i, j] = int.Parse(Console.ReadLine());
            }

        // Input Matrix 2
        Console.WriteLine("\nEnter elements of Matrix 2:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write("mat2[" + (i + 1) + "][" + (j + 1) + "]: ");
                mat2[i, j] = int.Parse(Console.ReadLine());
            }

        // ==============================
        //       MATRIX ADDITION
        // ==============================
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = mat1[i, j] + mat2[i, j];

        // ==============================
        //       DISPLAY MATRICES
        // ==============================
        Console.WriteLine("\n--- Matrix 1 ---");
        PrintMatrix(mat1, rows, cols);

        Console.WriteLine("\n--- Matrix 2 ---");
        PrintMatrix(mat2, rows, cols);

        Console.WriteLine("\n--- Result Matrix (Mat1 + Mat2) ---");
        PrintMatrix(result, rows, cols);
    }

    // Method to print matrix
    static void PrintMatrix(int[,] mat, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < cols; j++)
                Console.Write(mat[i, j].ToString().PadLeft(4));
            Console.WriteLine("  |");
        }
    }
}