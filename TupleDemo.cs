using System;

class TupleDemo
{
    static void Main()
    {
        // Simple Tuple
        var student = (101, "Rahul", 88.5);
        Console.WriteLine("── Simple Tuple ──");
        Console.WriteLine($"ID    : {student.Item1}");
        Console.WriteLine($"Name  : {student.Item2}");
        Console.WriteLine($"Marks : {student.Item3}");

        // Named Tuple
        var emp = (Id: 201, Name: "Priya", Salary: 50000);
        Console.WriteLine("\n── Named Tuple ──");
        Console.WriteLine($"ID     : {emp.Id}");
        Console.WriteLine($"Name   : {emp.Name}");
        Console.WriteLine($"Salary : {emp.Salary}");

        // Tuple in Method
        var result = GetStudent();
        Console.WriteLine("\n── Tuple from Method ──");
        Console.WriteLine($"ID    : {result.Id}");
        Console.WriteLine($"Name  : {result.Name}");
        Console.WriteLine($"Marks : {result.Marks}");
    }

    // Method returning Tuple
    static (int Id, string Name, double Marks) GetStudent()
    {
        return (103, "Amit", 95.0);
    }
}
