using System;

// Base class
class Shape1
{
    public double area;   // Public variable

    public virtual void CalculateArea()
    {
        Console.WriteLine("Area: " + area);
    }
}

// Derived class Circle
class Circle : Shape1
{
    public double radius;   // Public variable

    public override void CalculateArea()
    {
        area = 3.14 * radius * radius;
        Console.WriteLine("Area of Circle: " + area);
    }
}

// Derived class Rectangle
class Rectangle : Shape1
{
    public double length;   // Public variable
    public double width;    // Public variable

    public override void CalculateArea()
    {
        area = length * width;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Circle
        Circle c = new Circle();
        Console.Write("Enter radius of circle: ");
        c.radius = Convert.ToDouble(Console.ReadLine());
        c.CalculateArea();

        // Rectangle
        Rectangle r = new Rectangle();
        Console.Write("\nEnter length of rectangle: ");
        r.length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of rectangle: ");
        r.width = Convert.ToDouble(Console.ReadLine());

        r.CalculateArea();

        Console.ReadLine();
    }
}