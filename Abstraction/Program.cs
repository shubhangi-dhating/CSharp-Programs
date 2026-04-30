using System;

// Abstract class
abstract class Animal
{
    // Abstract method
    public abstract void Sound();

    // Normal method
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
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
        // Creating object of derived class
        Dog d1 = new Dog();

        d1.Sound();   // Abstract method implementation
        d1.Sleep();   // Normal method from abstract class

        Console.ReadLine();
    }
}
