using System;
using System.IO;

class FileExample
{
    static void Main()
    {
        string path = "sample.txt";

        // Writing to file using StreamWriter
        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine("Hello, this is a sample text file.");
        writer.WriteLine("File handling in C# using StreamWriter and StreamReader.");
        writer.Close();

        Console.WriteLine("Data written to file successfully.");

        // Reading from file using StreamReader
        StreamReader reader = new StreamReader(path);
        string line;

        Console.WriteLine("\nReading data from file:");

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        reader.Close();
    }
}
