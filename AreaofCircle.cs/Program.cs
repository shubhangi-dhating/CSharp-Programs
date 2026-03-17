using System;
class AreaofCircle
{
    public static void Main(string[] args)
    { //AreaofCircle circle = new AreaofCircle();

        Console.Write("Enter radius of the circle: ");

        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle is: " + area);

        Console.ReadLine();

    }
}