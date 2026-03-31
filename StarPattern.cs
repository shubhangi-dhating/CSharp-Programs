using System;

class StarPatterns
{
    public static void Main()
    {
        int n = 5;

        Console.WriteLine("1. Right Triangle:");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));
        }

        Console.WriteLine("\n2. Inverted Right Triangle:");
        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(new string('*', i));
        }

        Console.WriteLine("\n3. Pyramid:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }

        Console.WriteLine("\n4. Inverted Pyramid:");
        for (int i = n; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }

        Console.WriteLine("\n5. Diamond:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }

        Console.WriteLine("\n6. Hollow Square:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i == 1 || i == n || j == 1 || j == n ? "* " : "  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n7. Right Pascal Triangle:");
        for (int i = 1; i <= n; i++)
            Console.WriteLine(new string('*', i));
        for (int i = n - 1; i >= 1; i--)
            Console.WriteLine(new string('*', i));

        Console.WriteLine("\n8. Hourglass:");
        for (int i = n; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        for (int i = 2; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}
