using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Rahul", "Amit", "Sneha", "Riya", "Ankit", "Sonal" };

        // Group names by first letter
        var groups = names.GroupBy(name => name[0]);

        Console.WriteLine("Grouped Names:");

        foreach (var group in groups)
        {
            Console.WriteLine("Group: " + group.Key);

            foreach (string name in group)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

