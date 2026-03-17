// See https://aka.ms/new-console-template for more information
using System;
class Ascii
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Character:");
        char ch = Convert.ToChar(Console.ReadLine());

        int asciiValue = (int)ch;

        Console.WriteLine("ASCII value of " + ch + " is: " + asciiValue);

        Console.ReadLine();


    }
}
