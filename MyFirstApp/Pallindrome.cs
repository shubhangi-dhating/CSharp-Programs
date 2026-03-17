using System;
class Pallindrome
{
    public static void Main(string[] args)
    {
        int Number, rev = 0, remender,temp;
        Console.WriteLine("Enter a number to check if it is a pallindrome:");
        Number = Convert.ToInt32(Console.ReadLine());
        temp=Number;
        while(Number > 0)
        {
            remender = Number % 10;
            rev = rev * 10 + remender;
            Number = Number / 10;
        
        }

         if(temp==rev)
            Console.WriteLine("The number is pallindrome: " + rev);
        else
            Console.WriteLine("the number is not pallindrome:" + rev);
    }
}