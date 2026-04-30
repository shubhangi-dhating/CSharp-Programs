using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object of derived class
        Dog d1 = new Dog();

        // Accessing base class method
        d1.Eat();

        // Accessing derived class method
        d1.Bark();

        Console.ReadLine();
    }
}
