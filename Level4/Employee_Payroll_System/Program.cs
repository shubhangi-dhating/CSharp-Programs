// Console-based Employee Payroll System in C#

using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public double BasicSalary;
    public double HRA;
    public double DA;
    public double GrossSalary;

    public void CalculateSalary()
    {
        HRA = BasicSalary * 0.20;   // 20% HRA
        DA = BasicSalary * 0.10;    // 10% DA
        GrossSalary = BasicSalary + HRA + DA;
    }
}

class PayrollSystem
{
    List<Employee> employees = new List<Employee>();

    public void AddEmployee()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee ID: ");
        emp.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        emp.BasicSalary = Convert.ToDouble(Console.ReadLine());

        emp.CalculateSalary();
        employees.Add(emp);

        Console.WriteLine("Employee Added Successfully!\n");
    }

    public void ViewEmployees()
    {
        Console.WriteLine("\n===== Employee Payroll Details =====");

        foreach (Employee emp in employees)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ID           : " + emp.Id);
            Console.WriteLine("Name         : " + emp.Name);
            Console.WriteLine("Basic Salary : " + emp.BasicSalary);
            Console.WriteLine("HRA          : " + emp.HRA);
            Console.WriteLine("DA           : " + emp.DA);
            Console.WriteLine("Gross Salary : " + emp.GrossSalary);
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        PayrollSystem payroll = new PayrollSystem();
        int choice;

        do
        {
            Console.WriteLine("===== Employee Payroll System =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Payroll Details");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    payroll.AddEmployee();
                    break;
                case 2:
                    payroll.ViewEmployees();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!\n");
                    break;
            }

        } while (choice != 3);
    }
}

