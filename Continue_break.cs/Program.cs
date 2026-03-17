using System;
class CBreak
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating break statement:");

        for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                break;
            }

            Console.WriteLine(i);
        }

        Console.WriteLine("\nDEmomstrating COntinue statement:");

        for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine(i);
        ////}
    }
}