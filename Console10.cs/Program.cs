using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLINQExample
{
    // Student class
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating list of students
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Rahul", Age = 20, Marks = 85 },
                new Student { Id = 2, Name = "Sneha", Age = 19, Marks = 92 },
                new Student { Id = 3, Name = "Amit", Age = 21, Marks = 75 },
                new Student { Id = 4, Name = "Priya", Age = 20, Marks = 88 },
                new Student { Id = 5, Name = "Karan", Age = 22, Marks = 65 }
            };

            // Search student by name
            Console.WriteLine("Search Student by Name (Rahul):");
            var searchStudent = students.Where(s => s.Name == "Rahul");

            foreach (var s in searchStudent)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Age} {s.Marks}");
            }

            Console.WriteLine();

            // Filter students with marks greater than 80
            Console.WriteLine("Students with Marks > 80:");
            var highMarks = students.Where(s => s.Marks > 80);

            foreach (var s in highMarks)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Age} {s.Marks}");
            }

            Console.WriteLine();

            // Sort students by marks
            Console.WriteLine("Students Sorted by Marks:");
            var sortedStudents = students.OrderBy(s => s.Marks);

            foreach (var s in sortedStudents)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Age} {s.Marks}");
            }

            Console.ReadLine();
        }
    }
}