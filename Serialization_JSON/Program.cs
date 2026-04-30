using System;
using System.Text.Json;

// Class to serialize
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student
        {
            Id = 101,
            Name = "Rahul"
        };

        // Convert object to JSON
        string json = JsonSerializer.Serialize(s1);

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);

        // Convert JSON to object
        Student s2 = JsonSerializer.Deserialize<Student>(json);

        Console.WriteLine("\nDeserialized Object:");
        Console.WriteLine("Id = " + s2.Id);
        Console.WriteLine("Name = " + s2.Name);

        Console.ReadLine();
    }
}
