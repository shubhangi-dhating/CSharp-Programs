using System;

interface IEmployee
{
    void CalculateSalary();
}

class FullTimeEmployee : IEmployee
{
    public void CalculateSalary()
    {
        int monthlySalary = 50000;
        Console.WriteLine("Full Time Employee Salary: " + monthlySalary);
    }
}

class PartTimeEmployee : IEmployee
{
    public void CalculateSalary()
    {
        int hourlyRate = 200;
        int hoursWorked = 80;
        int salary = hourlyRate * hoursWorked;
        Console.WriteLine("Part Time Employee Salary: " + salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IEmployee emp;

        emp = new FullTimeEmployee();
        emp.CalculateSalary();

        emp = new PartTimeEmployee();
        emp.CalculateSalary();
    }
}
