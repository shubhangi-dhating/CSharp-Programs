using System;
using System.Text.RegularExpressions;

class SalaryCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Salary Calculator ===\n");

        Console.Write("Enter Employee Name  : ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary   : ");
        double basic = double.Parse(Console.ReadLine());

        // Allowances
        double hra = basic * 0.20;
        double da = basic * 0.15;
        double ta = basic * 0.10;

        // Deductions
        double pf = basic * 0.12;
        double tax = basic * 0.05;

        double gross = basic + hra + da + ta;
        double net = gross - pf - tax;

        // Output
        Console.WriteLine("\n-------- Pay Slip --------");
        Console.WriteLine($"Name         : {name}");
        Console.WriteLine($"Basic Salary : {basic:F2}");
        Console.WriteLine($"HRA  (20%)   : {hra:F2}");
        Console.WriteLine($"DA   (15%)   : {da:F2}");
        Console.WriteLine($"TA   (10%)   : {ta:F2}");
        Console.WriteLine($"Gross Salary : {gross:F2}");
        Console.WriteLine($"PF   (12%)   : -{pf:F2}");
        Console.WriteLine($"Tax   (5%)   : -{tax:F2}");
        Console.WriteLine($"Net Salary   : {net:F2}");
        Console.WriteLine("--------------------------");
    }
}
