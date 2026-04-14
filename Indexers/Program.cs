using System;

class Student
{
    private string[] names = new string[5];

    // Indexer
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < names.Length)
                return names[index];
            else
                return "Invalid Index";
        }
        set
        {
            if (index >= 0 && index < names.Length)
                names[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        // Setting values using indexer
        s[0] = "Rahul";
        s[1] = "Anita";
        s[2] = "John";

        // Getting values using indexer
        Console.WriteLine("Student Names:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(s[i]);
        }
    }
}
