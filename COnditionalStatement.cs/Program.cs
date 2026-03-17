using System;

class ConditionalDemo
{
    public static void Main(string[] args)
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // if statement
        if (number > 0)
        {
            Console.WriteLine("The number is Positive");
        }

        // if-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }

        // if-else-if ladder
        if (number > 0)
        {
            Console.WriteLine("Positive number");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative number");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }
    }
}