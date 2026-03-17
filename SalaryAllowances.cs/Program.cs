using System;

class SalaryDemo
{
    public static void Main(string[] args)
    {
        double basic, hra, da, total;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        hra = basic * 0.20;   // House Rent Allowance (20%)
        da = basic * 0.10;    // Dearness Allowance (10%)

        total = basic + hra + da;

        Console.WriteLine("Basic Salary: " + basic);
        Console.WriteLine("HRA: " + hra);
        Console.WriteLine("DA: " + da);
        Console.WriteLine("Total Salary: " + total);
    }
}