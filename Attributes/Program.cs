using System;

// Custom attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class MyInfoAttribute : Attribute
{
    public string Author { get; }
    public string Version { get; }

    public MyInfoAttribute(string author, string version)
    {
        Author = author;
        Version = version;
    }
}

// Applying attribute to class
[MyInfo("Rahul", "1.0")]
class Demo
{
    // Applying attribute to method
    [MyInfo("Rahul", "1.0")]
    public void Show()
    {
        Console.WriteLine("Method Executed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Demo d = new Demo();
        d.Show();

        Console.WriteLine("Attributes Demonstration Completed.");

        Console.ReadLine();
    }
}


