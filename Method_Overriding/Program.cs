using System;

// Base class
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived class
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Dog();

        // Calls overridden method
        a1.Sound();

        Console.ReadLine();
    }
}
