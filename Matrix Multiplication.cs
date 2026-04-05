using System;

class MatrixMultiplication
{
    static void Main(string[] args)
    {
        // Input Matrix 1 dimensions
        Console.WriteLine("=== Matrix 1 ===");
        Console.Write("Enter number of Rows:    ");
        int rows1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of Columns: ");
        int cols1 = int.Parse(Console.ReadLine());

        // Input Matrix 2 dimensions
        Console.WriteLine("\n=== Matrix 2 ===");
        Console.Write("Enter number of Rows:    ");
        int rows2 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of Columns: ");
        int cols2 = int.Parse(Console.ReadLine());

        // ==============================
        //    VALIDATE MULTIPLICATION
        // ==============================
        if (cols1 != rows2)
        {
            Console.WriteLine("\n❌ Matrix multiplication NOT possible!");
            Console.WriteLine("Columns of Matrix 1 must equal Rows of Matrix 2");
            Console.WriteLine("Matrix 1 columns: " + cols1 + ", Matrix 2 rows: " + rows2);
            return;
        }

        int[,] mat1 = new int[rows1, cols1];
        int[,] mat2 = new int[rows2, cols2];
        int[,] result = new int[rows1, cols2];

        // Input Matrix 1
        Console.WriteLine("\nEnter elements of Matrix 1:");
        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols1; j++)
            {
                Console.Write("mat1[" + (i + 1) + "][" + (j + 1) + "]: ");
                mat1[i, j] = int.Parse(Console.ReadLine());
            }

        // Input Matrix 2
        Console.WriteLine("\nEnter elements of Matrix 2:");
        for (int i = 0; i < rows2; i++)
            for (int j = 0; j < cols2; j++)
            {
                Console.Write("mat2[" + (i + 1) + "][" + (j + 1) + "]: ");
                mat2[i, j] = int.Parse(Console.ReadLine());
            }

        // ==============================
        //     MATRIX MULTIPLICATION
        // ==============================
        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols2; j++)
                for (int k = 0; k < cols1; k++)
                    result[i, j] += mat1[i, k] * mat2[k, j];

        // ==============================
        //       DISPLAY MATRICES
        // ==============================
        Console.WriteLine("\n--- Matrix 1 (" + rows1 + "x" + cols1 + ") ---");
        PrintMatrix(mat1, rows1, cols1);

        Console.WriteLine("\n--- Matrix 2 (" + rows2 + "x" + cols2 + ") ---");
        PrintMatrix(mat2, rows2, cols2);

        Console.WriteLine("\n--- Result Matrix (" + rows1 + "x" + cols2 + ") ---");
        PrintMatrix(result, rows1, cols2);
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