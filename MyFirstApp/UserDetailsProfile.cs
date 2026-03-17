using System;
class UserDEtails
{
    public static void Main(string[] args)
    {
        Console.WriteLine("**** User Details****");
        Console.WriteLine("Enter Your Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Your Addrress:");
        string add = Console.ReadLine();
        Console.WriteLine("Enter Your Email Id:");
        string email = Console.ReadLine();
        Console.WriteLine("\n***** User Details Are *****");
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + add);
        Console.WriteLine("Email Id: " + email);


    }
}