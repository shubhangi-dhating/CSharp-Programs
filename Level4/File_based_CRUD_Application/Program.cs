// File-based CRUD Application in C#
// Stores Employee Records in employees.txt

using System;
using System.IO;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}

class EmployeeCRUD
{
    string filePath = "employees.txt";

    // Create
    public void AddEmployee()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee ID: ");
        emp.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Department: ");
        emp.Department = Console.ReadLine();

        Console.Write("Enter Salary: ");
        emp.Salary = Convert.ToDouble(Console.ReadLine());

        string record = emp.Id + "," + emp.Name + "," + emp.Department + "," + emp.Salary;
        File.AppendAllText(filePath, record + Environment.NewLine);

        Console.WriteLine("Employee Added Successfully!\n");
    }

    // Read
    public void ViewEmployees()
    {
        if (File.Exists(filePath))
        {
            string[] records = File.ReadAllLines(filePath);

            Console.WriteLine("\n===== Employee Records =====");

            foreach (string record in records)
            {
                string[] data = record.Split(',');

                Console.WriteLine("--------------------------------");
                Console.WriteLine("ID         : " + data[0]);
                Console.WriteLine("Name       : " + data[1]);
                Console.WriteLine("Department : " + data[2]);
                Console.WriteLine("Salary     : " + data[3]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No Records Found!\n");
        }
    }

    // Update
    public void UpdateEmployee()
    {
        Console.Write("Enter Employee ID to Update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File Not Found!\n");
            return;
        }

        List<string> updatedRecords = new List<string>();
        bool found = false;

        foreach (string record in File.ReadAllLines(filePath))
        {
            string[] data = record.Split(',');

            if (Convert.ToInt32(data[0]) == id)
            {
                Console.Write("Enter New Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter New Department: ");
                string dept = Console.ReadLine();

                Console.Write("Enter New Salary: ");
                string salary = Console.ReadLine();

                updatedRecords.Add(id + "," + name + "," + dept + "," + salary);
                found = true;
            }
            else
            {
                updatedRecords.Add(record);
            }
        }

        File.WriteAllLines(filePath, updatedRecords);

        if (found)
            Console.WriteLine("Employee Updated Successfully!\n");
        else
            Console.WriteLine("Employee Not Found!\n");
    }

    // Delete
    public void DeleteEmployee()
    {
        Console.Write("Enter Employee ID to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File Not Found!\n");
            return;
        }

        List<string> remainingRecords = new List<string>();
        bool found = false;

        foreach (string record in File.ReadAllLines(filePath))
        {
            string[] data = record.Split(',');

            if (Convert.ToInt32(data[0]) == id)
            {
                found = true;
                continue;
            }

            remainingRecords.Add(record);
        }

        File.WriteAllLines(filePath, remainingRecords);

        if (found)
            Console.WriteLine("Employee Deleted Successfully!\n");
        else
            Console.WriteLine("Employee Not Found!\n");
    }
}

class Program
{
    static void Main()
    {
        EmployeeCRUD crud = new EmployeeCRUD();
        int choice;

        do
        {
            Console.WriteLine("===== File-based CRUD Application =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    crud.AddEmployee();
                    break;
                case 2:
                    crud.ViewEmployees();
                    break;
                case 3:
                    crud.UpdateEmployee();
                    break;
                case 4:
                    crud.DeleteEmployee();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!\n");
                    break;
            }

        } while (choice != 5);
    }
}

