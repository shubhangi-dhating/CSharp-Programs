// Console-based Banking System in C#

using System;

class BankAccount
{
    public int AccountNumber;
    public string Name;
    public double Balance;

    public void CreateAccount()
    {
        Console.Write("Enter Account Number: ");
        AccountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Customer Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        Balance = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Account Created Successfully!\n");
    }

    public void Deposit()
    {
        Console.Write("Enter Amount to Deposit: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Balance += amount;
        Console.WriteLine("Amount Deposited Successfully!\n");
    }

    public void Withdraw()
    {
        Console.Write("Enter Amount to Withdraw: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal Successful!\n");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!\n");
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine("\n===== Account Details =====");
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Customer Name : " + Name);
        Console.WriteLine("Balance       : " + Balance);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        int choice;

        do
        {
            Console.WriteLine("===== Banking System =====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Show Account Details");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    account.CreateAccount();
                    break;
                case 2:
                    account.Deposit();
                    break;
                case 3:
                    account.Withdraw();
                    break;
                case 4:
                    account.ShowDetails();
                    break;
                case 5:
                    Console.WriteLine("Thank You!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!\n");
                    break;
            }

        } while (choice != 5);
    }
}

