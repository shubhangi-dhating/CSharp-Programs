using System;

class TransposeMatrix
{
    static void Main(string[] args)
    {
        // Input matrix dimensions
        Console.Write("Enter number of Rows:    ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of Columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] mat = new int[rows, cols];
        int[,] transpose = new int[cols, rows];

        // Input Matrix elements
        Console.WriteLine("\nEnter elements of Matrix:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write("mat[" + (i + 1) + "][" + (j + 1) + "]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }

        // ==============================
        //      TRANSPOSE MATRIX
        // ==============================
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transpose[j, i] = mat[i, j];

        // ==============================
        //       DISPLAY MATRICES
        // ==============================
        Console.WriteLine("\n--- Original Matrix (" + rows + "x" + cols + ") ---");
        PrintMatrix(mat, rows, cols);

        Console.WriteLine("\n--- Transpose Matrix (" + cols + "x" + rows + ") ---");
        PrintMatrix(transpose, cols, rows);
    }

    // Method to print matrix
    static void PrintMatrix(int[,] mat, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < cols; j++)
                Console.Write(mat[i, j].ToString().PadLeft(5));
            Console.WriteLine("  |");
        }
    }
}