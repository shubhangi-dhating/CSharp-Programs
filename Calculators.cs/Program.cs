using System;

class Calculator
{
    // Addition Method
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Subtraction Method
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Multiplication Method
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Division Method
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error! Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Simple Calculator =====");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 4)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;

                    case 2:
                        result = Subtract(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;

                    case 3:
                        result = Multiply(num1, num2);
                        Console.WriteLine("Result: " + result);
                        break;

                    case 4:
                        result = Divide(num1, num2);
                        if (num2 != 0)
                            Console.WriteLine("Result: " + result);
                        break;
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting Calculator... Thank you!");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }

        } while (choice != 5);   // Program continues until user selects Exit
    }
}

