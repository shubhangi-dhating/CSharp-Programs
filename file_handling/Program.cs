using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "sample.txt";

        // Write to file
        File.WriteAllText(path, "Hello, this is file handling in C#.");

        // Read from file
        string content = File.ReadAllText(path);

        Console.WriteLine("File Content:");
        Console.WriteLine(content);

        Console.ReadLine();
    }
}

