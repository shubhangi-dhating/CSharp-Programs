using System;

class ReadOnlyDemo
{
    readonly int number;

    public ReadOnlyDemo(int num)
    {
        number = num;   // value assigned in constructor
    }

    public void Display()
    {
        Console.WriteLine("Readonly number: " + number);
    }

    static void Main()
    {
        ReadOnlyDemo obj = new ReadOnlyDemo(10);
        obj.Display();
    }
}