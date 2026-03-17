using System;
class PosiNeg
{
    public static void Main(string[] args)
    {
        int Number;
        Console.WriteLine("Enter a Numberr:");
        Number = Convert.ToInt32(Console.ReadLine());

        if( Number>0)
            Console.WriteLine("The Number is Positive:" + Number);
          else
            Console.WriteLine("The Number is Negative:" + Number);
        if (Number==0)
            Console.WriteLine("The Number Is Zero:" + Number);
    }
}