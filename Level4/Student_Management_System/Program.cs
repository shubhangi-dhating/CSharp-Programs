using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    SearchStudent();
                    break;

                case 4:
                    DeleteStudent();
                    break;

                case 5:
                    Console.WriteLine("Exiting Program...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 5);
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        s.Age = Convert.ToInt32(Console.ReadLine());

        students.Add(s);

        Console.WriteLine("Student Added Successfully.");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\nStudent Records:");

        foreach (Student s in students)
        {
            Console.WriteLine("ID: " + s.Id +
                              " Name: " + s.Name +
                              " Age: " + s.Age);
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Student ID to Search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                Console.WriteLine("Found: " + s.Name + ", Age: " + s.Age);
                return;
            }
        }

        Console.WriteLine("Student Not Found.");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Student found = null;

        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                found = s;
                break;
            }
        }

        if (found != null)
        {
            students.Remove(found);
            Console.WriteLine("Student Deleted Successfully.");
        }
        else
        {
            Console.WriteLine("Student Not Found.");
        }
    }
}
