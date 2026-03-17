using System;
class ControlStatement
{
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Check Even or Odd");
                Console.WriteLine("2. Display Multiplication Table");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Using if-else
                        Console.Write("Enter a number: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        if (number % 2 == 0)
                            Console.WriteLine($"{number} is Even.");
                        else
                            Console.WriteLine($"{number} is Odd.");
                        break;

                    case 2:
                        Console.Write("Enter a number for multiplication table: ");
                        int table = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nMultiplication Table (using for loop):");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"{table} x {i} = {table * i}");
                        }

                        Console.WriteLine("\nMultiplication Table (using while loop):");
                        int j = 1;
                        while (j <= 10)
                        {
                            Console.WriteLine($"{table} x {j} = {table * j}");
                            j++;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 3); // do-while loop

            Console.ReadKey();
        }}