using System;

class Demo
{
    // const value must be assigned at declaration
    public const double PI = 3.14;

    // readonly value can be assigned at declaration or constructor
    public readonly int number;

    // Constructor
    public Demo(int n)
    {
        number = n;
    }

    public void Display()
    {
        Console.WriteLine("Const PI = " + PI);
        Console.WriteLine("Readonly Number = " + number);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Demo d1 = new Demo(100);

        d1.Display();

        Console.ReadLine();
    }
}
