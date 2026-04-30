using System;

class Student
{
    // Constructor
    public Student()
    {
        Console.WriteLine("Constructor is called.");
    }

    // Destructor
    ~Student()
    {
        Console.WriteLine("Destructor is called.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        // Object becomes eligible for garbage collection
        s1 = null;

        // Force garbage collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Main method ends.");
        Console.ReadLine();
    }
}
