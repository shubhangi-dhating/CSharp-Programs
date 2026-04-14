using System;

class Program
{
    static void Display(string name, int age, string city)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }

    static void Main()
    {
        // Calling method using named arguments
        Display(name: "Rahul", age: 22, city: "Mumbai");

        Console.WriteLine();

        // Changing order using named arguments
        Display(city: "Delhi", name: "Anita", age: 25);
    }
}
