using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;

            int result = a / b;   // Exception occurs

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block always executes.");
        }

        Console.ReadLine();
    }
}
