using System;

// First interface
interface IFather
{
    void ShowFather();
}

// Second interface
interface IMother
{
    void ShowMother();
}

// Class implementing multiple interfaces
class Child : IFather, IMother
{
    public void ShowFather()
    {
        Console.WriteLine("Father's method");
    }

    public void ShowMother()
    {
        Console.WriteLine("Mother's method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();

        c1.ShowFather();
        c1.ShowMother();

        Console.ReadLine();
    }
}
