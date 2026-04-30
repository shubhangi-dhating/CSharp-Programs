using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;

            int result = a / b;   // Causes exception

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.ReadLine();
    }
}
