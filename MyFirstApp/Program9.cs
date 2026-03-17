using System;
class LargerstOfThree
{
    public static void Main(string[] args)
    {
        int M;
        int N;
        int O;

        Console.WriteLine("Enter the First Number:");
        M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Seccond Number:");
        N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Third Number:");
        O = Convert.ToInt32(Console.ReadLine());

        if (M>N && M>O)
            Console.WriteLine("First Number is Largest:" + M);
        else if (N>M  && N>O)
            Console.WriteLine("Second Number is Larget:" + N);
        else
           Console.WriteLine("Third Number is largest:" + O);


    }
}