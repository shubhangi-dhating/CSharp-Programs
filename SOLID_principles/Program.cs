using System;

///////////////////////
// S - Single Responsibility Principle
///////////////////////
class Invoice
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculating invoice total...");
    }
}

class InvoicePrinter
{
    public void PrintInvoice()
    {
        Console.WriteLine("Printing invoice...");
    }
}

///////////////////////
// O - Open/Closed Principle
///////////////////////
abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double radius = 5;

    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}

class Rectangle : Shape
{
    public double length = 4;
    public double width = 3;

    public override double Area()
    {
        return length * width;
    }
}

///////////////////////
// L - Liskov Substitution Principle
///////////////////////
class Bird
{
    public virtual void Move()
    {
        Console.WriteLine("Bird moves.");
    }
}

class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Sparrow flies.");
    }
}

///////////////////////
// I - Interface Segregation Principle
///////////////////////
interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

class Printer : IPrint
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

///////////////////////
// D - Dependency Inversion Principle
///////////////////////
interface IMessageService
{
    void Send();
}

class SMSService : IMessageService
{
    public void Send()
    {
        Console.WriteLine("SMS Sent.");
    }
}

class Notification
{
    private IMessageService service;

    public Notification(IMessageService s)
    {
        service = s;
    }

    public void Notify()
    {
        service.Send();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // SRP
        Invoice inv = new Invoice();
        inv.CalculateTotal();

        InvoicePrinter printer = new InvoicePrinter();
        printer.PrintInvoice();

        // OCP
        Shape s1 = new Circle();
        Shape s2 = new Rectangle();

        Console.WriteLine("Circle Area = " + s1.Area());
        Console.WriteLine("Rectangle Area = " + s2.Area());

        // LSP
        Bird b = new Sparrow();
        b.Move();

        // ISP
        Printer p = new Printer();
        p.Print();

        // DIP
        IMessageService msg = new SMSService();
        Notification n = new Notification(msg);
        n.Notify();

        Console.ReadLine();
    }
}

