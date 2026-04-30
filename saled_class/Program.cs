using System;

// Sealed class
sealed class Animal
{
    public void Show()
    {
        Console.WriteLine("This is a sealed class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Animal();

        a1.Show();

        Console.ReadLine();
    }
}