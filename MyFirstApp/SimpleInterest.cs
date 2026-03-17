using System;
class SimpleInterest
{
    public static void Main(string[] args)
    {
        double principle,rate,time,simpleInterest;

        Console.WriteLine("Enter Principle Amount:");
        principle = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest:");
        rate = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Enter Time in Years:");
        time = Convert.ToSingle(Console.ReadLine());

        simpleInterest = (principle*rate*time)/100;
        Console.WriteLine("Simple Interest is:" + simpleInterest);
    }
}