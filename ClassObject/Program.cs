using System;

// Class definition
class Student
{
    // Data members (fields)
    public string name;
    public int age;

    // Method
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
        // Creating object of Student class
        Student s1 = new Student();

        // Assigning values to object
        s1.name = "Rahul";
        s1.age = 20;

        // Calling method using object
        s1.Display();

        Console.ReadLine();
    }
}
