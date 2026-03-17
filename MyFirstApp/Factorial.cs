using System;
class Factorial
{
    public static void Main(string[] args)
    {
        int num, fact = 1;
        Console.WriteLine("Enter a number to calculate its factorial:");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + num + " is: " + fact);
    }
}