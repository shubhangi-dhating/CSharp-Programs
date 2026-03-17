using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = 1;
        int min = (num1 < num2) ? num1 : num2;

        for (int i = 1; i <= min; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                gcd = i;
            }
        }

        Console.WriteLine($"\nGCD of {num1} and {num2} = {gcd}");

        Console.ReadLine();
    }
}

