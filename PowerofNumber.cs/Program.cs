using System;
class PowerofNumber
{
    public static void Main(string[] args)
    {
        int baseNum, power;
        int result = 1;

        Console.Write("Enter base number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter power: ");
        power = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= power; i++)
        {
            result = result * baseNum;
        }

        Console.WriteLine("Result = " + result);
    }
}