using System;

class Calculator
{
    // Method with two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method with three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method with double values
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Sum of 2 integers: " + calc.Add(5, 10));
        Console.WriteLine("Sum of 3 integers: " + calc.Add(5, 10, 15));
        Console.WriteLine("Sum of 2 doubles: " + calc.Add(5.5, 10.5));

        Console.ReadLine();
    }
}