using System;
class ArmstrongNumber
{
    public static void Main(string[] args)
    {
        int num,sum=0,temp,r;
        Console.WriteLine("Enter a Number:");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while(temp !=0)
        {
            r = temp % 10;
            sum = sum + r*r*r;
            temp = temp / 10;
        }
        if (sum == num)
            Console.WriteLine(num + " is an Armstromg Number");
            else
            Console.WriteLine(num + " is not an Armstrong Number");

    }
}