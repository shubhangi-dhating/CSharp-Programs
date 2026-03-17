// See https://aka.ms/new-console-template for more information
using System;
class AreaofRecangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of Rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of Rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("Area of the rectangle is: " + area);

        Console.ReadLine();

    }
}
