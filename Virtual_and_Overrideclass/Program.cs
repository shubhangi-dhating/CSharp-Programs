using System;

// Base class
class Animal
{
    // Virtual method
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Derived class
class Dog : Animal
{
    // Override method
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

        a1.Sound();

        Console.ReadLine();
    }
}
