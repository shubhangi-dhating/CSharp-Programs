using System;

// Custom Exception Class
class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int age = 15;

            if (age < 18)
            {
                throw new AgeException("Age must be 18 or above.");
            }

            Console.WriteLine("Eligible to vote.");
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program ended.");
        }

        Console.ReadLine();
    }
}

