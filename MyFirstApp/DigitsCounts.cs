using System;
class DigitsCounts
{
    public static void Main(string[] args)
    {
        int number,temp,count = 0;
        Console.WriteLine("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());
        count = 0;
        temp = Math.Abs(number);
        while (temp > 0)
        {
            temp /= 10;
            count++;
        
        }
        Console.WriteLine("Number of digits in the given number is:" + count);

    }
}
