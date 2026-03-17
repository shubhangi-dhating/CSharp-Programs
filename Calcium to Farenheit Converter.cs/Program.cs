// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class CalciumFarenheit
{
    public static void Main(string[] args)

    {
        Console.Write("Enter temperature in Celsius: ");

        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        Console.ReadLine();
    }
}