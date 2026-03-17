using System;
class Swap
{
    public static void Main(string[] args)
    {
        int a, b, temp;
        Console.WriteLine("Enter the value of a:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of b:");
        b = Convert.ToInt32(Console.ReadLine());

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("Value of a:" +a);
        Console.WriteLine("Value of b:" +b);
        
    }
}