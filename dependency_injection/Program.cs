using System;

// Service Interface
interface IMessage
{
    void SendMessage();
}

// Service Class
class EmailService : IMessage
{
    public void SendMessage()
    {
        Console.WriteLine("Email Sent.");
    }
}

// Client Class
class Notification
{
    private IMessage message;

    // Dependency Injection through constructor
    public Notification(IMessage msg)
    {
        message = msg;
    }

    public void Notify()
    {
        message.SendMessage();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessage service = new EmailService();

        Notification n1 = new Notification(service);

        n1.Notify();

        Console.ReadLine();
    }
}

