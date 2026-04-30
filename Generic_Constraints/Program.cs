using System;

// Generic class with constraint
class Demo<T> where T : class
{
    public void Show(T value)
    {
        Console.WriteLine("Value = " + value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Valid: string is a reference type
        Demo<string> d1 = new Demo<string>();
        d1.Show("Hello");

        // Invalid: int is value type
        // Demo<int> d2 = new Demo<int>();

        Console.ReadLine();
    }
}

