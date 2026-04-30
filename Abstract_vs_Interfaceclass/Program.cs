using System;

// Interface
interface IAnimal
{
    void Eat();
}

// Abstract class
abstract class Animal
{
    public abstract void Sound();

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

// Derived class using abstract class and interface
class Dog : Animal, IAnimal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks.");
    }

    public void Eat()
    {
        Console.WriteLine("Dog is eating.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d1 = new Dog();

        d1.Sound();   // From abstract class
        d1.Sleep();   // Normal method from abstract class
        d1.Eat();     // From interface

        Console.ReadLine();
    }
}
