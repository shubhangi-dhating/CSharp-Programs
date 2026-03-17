using System;

class Program
{
    // Method to calculate GCD using Euclidean Algorithm
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Method to calculate LCM
    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = FindGCD(num1, num2);
        int lcm = FindLCM(num1, num2);

        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }
}