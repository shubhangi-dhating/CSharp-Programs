using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();

            Console.WriteLine("\nEnter details of student " + (i + 1));

            Console.Write("ID: ");
            s.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Marks: ");
            s.Marks = Convert.ToInt32(Console.ReadLine());

            students.Add(s);
        }

        // Filter students with marks > 75
        var result = students.Where(s => s.Marks > 75);

        Console.WriteLine("\nStudents with Marks > 75:");
        foreach (var s in result)
        {
            Console.WriteLine("ID: " + s.Id + " Name: " + s.Name + " Marks: " + s.Marks);
        }

        // Search student by name
        Console.Write("\nEnter name to search: ");
        string searchName = Console.ReadLine();

        var search = students.Where(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\nSearch Result:");

        if (search.Any())
        {
            foreach (var s in search)
            {
                Console.WriteLine("ID: " + s.Id + " Name: " + s.Name + " Marks: " + s.Marks);
            }
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}