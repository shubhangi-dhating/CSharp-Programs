using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nPrime numbers between {start} and {end}:\n");

        for (int num = start; num <= end; num++)
        {
            if (num <= 1)
                continue;

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(num + " ");
            }
        }

        Console.ReadLine();
    }
}

