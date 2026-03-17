using System;

class Student
{
    // Properties
    public int RollNo { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    // Default Constructor
    public Student()
    {
        RollNo = 0;
        Name = "Not Assigned";
        Marks = 0.0;
    }

    // Parameterized Constructor
    public Student(int rollNo, string name, double marks)
    {
        RollNo = rollNo;
        Name = name;
        Marks = marks;
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Roll No: " + RollNo);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Marks: " + Marks);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // Taking input from user
        Console.Write("Enter Roll No: ");
        int roll = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        // Creating object using parameterized constructor
        Student s1 = new Student(roll, name, marks);

        Console.WriteLine("\nStudent Details:");
        s1.Display();
    }
}
