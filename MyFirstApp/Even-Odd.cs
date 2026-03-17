using System;
class EvenOdd
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter a Number:");
        num = Convert. ToInt32(Console.ReadLine());

        if(num % 2 == 0)
            Console.WriteLine("The number is Even:" + num);
        else
            Console.WriteLine("The Number is Odd:" +num);

    }
}