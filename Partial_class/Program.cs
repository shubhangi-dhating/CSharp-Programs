using System;

// First part of partial class
partial class Student
{
    public void ShowName()
    {
        Console.WriteLine("Name: Rahul");
    }
}

// Second part of partial class
partial class Student
{
    public void ShowAge()
    {
        Console.WriteLine("Age: 20");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.ShowName();
        s1.ShowAge();

        Console.ReadLine();
    }
}