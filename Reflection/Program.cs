using System;
using System.Reflection;

class Student
{
    public int Id;
    public string Name;

    public void Show()
    {
        Console.WriteLine("Student Method Called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get type information
        Type t = typeof(Student);

        Console.WriteLine("Class Name: " + t.Name);

        // Display fields
        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in t.GetFields())
        {
            Console.WriteLine(field.Name);
        }

        // Display methods
        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.ReadLine();
    }
}

