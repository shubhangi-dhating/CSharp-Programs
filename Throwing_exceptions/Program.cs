using System;

class Program
{
    static void CheckNumber(int num)
    {
        if (num < 0)
        {
            throw new Exception("Number cannot be negative.");
        }

        Console.WriteLine("Valid Number: " + num);
    }

    static void Main(string[] args)
    {
        try
        {
            CheckNumber(-5);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program ended.");
        }

        Console.ReadLine();
    }
}

