using System;
class Addition
{
    public static void Main(string[] args)
    {
        int a;
        int b;
        int add;

        Console.WriteLine("Enter First Number:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number:");
        b = Convert.ToInt32(Console.ReadLine());

        add = a + b;
        Console.WriteLine("Addition of Two Numbers is:" + add);

    }
}