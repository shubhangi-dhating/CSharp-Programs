using System;
class Reverse
{
    public static void Main(string[] args)
    {
        int Number, rev = 0 , remender;
        Console.WriteLine("Enter a number to reverse:");
        Number = Convert.ToInt32(Console.ReadLine());
        while(Number > 0)
        {
            remender = Number % 10;
            rev = rev * 10 + remender;
            Number = Number / 10;
        }

        
        Console.WriteLine("Reversed Number: " + rev);
    }
}