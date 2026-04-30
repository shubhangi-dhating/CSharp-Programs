using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating ArrayList
        ArrayList list = new ArrayList();

        // Adding elements
        list.Add(10);
        list.Add("Rahul");
        list.Add(25.5);
        list.Add(true);

        // Displaying elements
        Console.WriteLine("ArrayList Elements:");

        foreach (object item in list)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}

