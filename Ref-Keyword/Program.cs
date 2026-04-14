using System;

class Program
{
    // Using ref keyword
    static void UsingRef(ref int x)
    {
        x = x + 10;
        Console.WriteLine("Inside UsingRef: " + x);
    }

    // Using out keyword
    static void UsingOut(out int y)
    {
        y = 20; // must assign before use
        Console.WriteLine("Inside UsingOut: " + y);
    }

    static void Main()
    {
        int a = 5;
        Console.WriteLine("Before UsingRef: " + a);
        UsingRef(ref a);
        Console.WriteLine("After UsingRef: " + a);

        int b; // no need to initialize
        UsingOut(out b);
        Console.WriteLine("After UsingOut: " + b);
    }
}
