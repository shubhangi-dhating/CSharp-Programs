using System;

class Program
{
    static void Main(string[] args)
    {
        // Func: takes two int parameters and returns sum
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine("Func Result = " + add(10, 20));

        // Action: takes one string parameter and returns void
        Action<string> show = name =>
            Console.WriteLine("Hello " + name);
        show("Rahul");

        // Predicate: takes int parameter and returns bool
        Predicate<int> isEven = n => n % 2 == 0;
        Console.WriteLine("Is 4 Even? " + isEven(4));

        Console.ReadLine();
    }
}
