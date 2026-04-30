using System;

class Demo
{
    public int a = 10;        // Accessible everywhere
    private int b = 20;       // Accessible only inside class
    protected int c = 30;     // Accessible in derived class
    internal int d = 40;      // Accessible within same assembly

    public void Show()
    {
        Console.WriteLine("Private b = " + b);
    }
}

// Derived class
class Test : Demo
{
    public void Display()
    {
        Console.WriteLine("Public a = " + a);
        Console.WriteLine("Protected c = " + c);
        Console.WriteLine("Internal d = " + d);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test t1 = new Test();

        t1.Display();

        Console.WriteLine("Public a = " + t1.a);
        Console.WriteLine("Internal d = " + t1.d);

        t1.Show();

        Console.ReadLine();
    }
}