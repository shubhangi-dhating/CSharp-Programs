using System;
class Fibonacci
{
    public static void Main(string[] args)
    {
        int num, a = 0, b = 1, c;
        Console.WriteLine("Enter the number of terms to display in Fibonacci series:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonacci series:");
        for (int i = 0; i < num; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}