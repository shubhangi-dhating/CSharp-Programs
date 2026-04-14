using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0) // Base case
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1); // Recursive call
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int result = Factorial(num);

        Console.WriteLine("Factorial = " + result);
    }
}
