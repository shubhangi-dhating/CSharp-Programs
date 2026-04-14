using System;

class Program
{
    // Static method
    static void ShowMessage()
    {
        Console.WriteLine("This is a static method.");
    }

    // Static method with parameters
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        // Calling static methods without creating object
        ShowMessage();

        int result = Add(10, 20);
        Console.WriteLine("Sum: " + result);
    }
}
