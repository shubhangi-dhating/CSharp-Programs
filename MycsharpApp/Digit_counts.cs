using System;

class DigitsCount
{
    public static void Main(string [] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int temp = Math.Abs(number); // Handles negative numbers

        if (temp == 0)
        {
            count = 1;
        }
        else
        {
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }
        }

        Console.WriteLine("Number of digits: " + count);
    }
}