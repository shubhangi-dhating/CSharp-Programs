using System;

class Student
{
    // Data members (no get/set)
    public int studentId;
    public string name;
    public int age;
    public string course;

    // Default Constructor
    public Student()
    {
    }

    // Parameterized Constructor
    public Student(int id, string n, int a, string c)
    {
        studentId = id;
        name = n;
        age = a;
        course = c;
    }

    // Method to input details
    public void Input()
    {
        Console.Write("Enter Student ID: ");
        studentId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Course: ");
        course = Console.ReadLine();
    }

    // Method to display details
    public void Display()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Course: " + course);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Input();
        s1.Display();

        Console.ReadLine();
    }
}
