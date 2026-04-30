using System;

// Interface
interface IAnimal
{
    void Sound();
}

// Class implementing interface
class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object
        IAnimal a1 = new Dog();

        a1.Sound();

        Console.ReadLine();
    }
}
