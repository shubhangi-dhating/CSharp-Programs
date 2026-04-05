using System;

struct Student
{
    public int Id;
    public string Name;
    public float Marks;

    public void Display()
    {
        Console.WriteLine($"ID    : {Id}");
        Console.WriteLine($"Name  : {Name}");
        Console.WriteLine($"Marks : {Marks}");
    }
}

class StructDemo
{
    static void Main()
    {
        // Create struct object
        Student s1;
        s1.Id = 101;
        s1.Name = "Rahul";
        s1.Marks = 88.5f;

        Student s2;
        s2.Id = 102;
        s2.Name = "Priya";
        s2.Marks = 92.0f;

        Console.WriteLine("── Student 1 ──");
        s1.Display();

        Console.WriteLine("\n── Student 2 ──");
        s2.Display();
    }
}
