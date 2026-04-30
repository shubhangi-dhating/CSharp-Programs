using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Adding key-value pairs
        students.Add(101, "Rahul");
        students.Add(102, "Amit");
        students.Add(103, "Sneha");

        // Displaying Dictionary elements
        Console.WriteLine("Student Dictionary:");

        foreach (KeyValuePair<int, string> item in students)
        {
            Console.WriteLine("Roll No: " + item.Key + " Name: " + item.Value);
        }

        Console.ReadLine();
    }
}

