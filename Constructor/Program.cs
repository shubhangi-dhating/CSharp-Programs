using System;

// Class with constructor
class Student
{
    string name;
    int age;

    // Constructor
    public Student(string n, int a)
    {
        name = n;
        age = a;
    }

    // Method to display values
    public void Display()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object and calling constructor
        Student s1 = new Student("Rahul", 20);

        s1.Display();

        Console.ReadLine();
    }
}
