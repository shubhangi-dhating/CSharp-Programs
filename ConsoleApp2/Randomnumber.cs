using System;
class Randomnumber
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Random Numbers:");

        for (int i = 1; i <= 5; i++)
        {
            int number = rand.Next(1, 100);
            Console.WriteLine(number);
        }
    }
    
}
