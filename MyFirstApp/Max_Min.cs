using System;
class Maximum
{
    public static void Main(string[] args)
    {
        int p;
        int q;
         
        Console.WriteLine("Enter the First Number:");
         p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number:");
         q = Convert.ToInt32(Console.ReadLine());

        if(p>q)
        
            Console.WriteLine("First Number Is Maximum:" +p);
        
        else
        
            Console.WriteLine("Second Number is Maximum:" +q);
        
         
    }
}