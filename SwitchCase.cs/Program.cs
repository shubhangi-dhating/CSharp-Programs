using System;
class SwitchCase
{
    public static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("Menu");
       // Console.WriteLine("Enter Your Choice:");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");

        Console.WriteLine("Enter Your Choice:");
        choice = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Enter a First Number:");
       int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a second Number:");
        int b = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Addition = " + (a + b));
                break;

            case 2:
                Console.WriteLine("Subtraction = " + (a - b));
                break;

            case 3:
                Console.WriteLine("Multiplication" + (a * b));
                break;

            case 4:
                Console.WriteLine("Division " + (a / b) );
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        
        
        }


    }
}
