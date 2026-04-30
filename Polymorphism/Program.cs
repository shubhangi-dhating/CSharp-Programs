using System;

// Base class
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
}

// Derived class 1
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

// Derived class 2
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Polymorphism using base class reference
        Shape s;

        s = new Circle();
        s.Draw();

        s = new Rectangle();
        s.Draw();

        Console.ReadLine();
    }
}
