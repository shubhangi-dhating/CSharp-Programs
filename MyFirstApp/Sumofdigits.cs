using System;

class Sumofdigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int temp = Math.Abs(number);

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}

