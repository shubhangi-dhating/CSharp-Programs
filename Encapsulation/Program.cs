using System;

// Class demonstrating Encapsulation
class Student
{
    // Private data members
    private string name;
    private int age;

    // Public method to set values
    public void SetData(string n, int a)
    {
        name = n;
        age = a;
    }

    // Public method to get values
    public void GetData()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        // Accessing data through public methods
        s1.SetData("Rahul", 20);
        s1.GetData();

        Console.ReadLine();
    }
}
