using System;

// Base class
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

// Derived class Circle
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Circle c = new Circle(5);
        Rectangle r = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + c.CalculateArea());
        Console.WriteLine("Rectangle Area: " + r.CalculateArea());
    }
}
