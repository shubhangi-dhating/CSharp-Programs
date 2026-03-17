using System;

class SumOfDigits1
{
    static void Main()
    {
      int number, temp,sum = 0;
      
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        sum = 0;
        temp = Math.Abs(number);

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
