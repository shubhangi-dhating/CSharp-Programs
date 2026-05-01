// CRUD using Entity Framework Core in C#
// Install Package:
// Microsoft.EntityFrameworkCore
// Microsoft.EntityFrameworkCore.SqlServer
// Microsoft.EntityFrameworkCore.Tools

using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUD
{
    // Model Class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    // DbContext Class
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=CompanyDB;Integrated Security=True");
        }
    }

    class Program
    {
        static void Main()
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            int choice;

            do
            {
                Console.WriteLine("===== Entity Framework Core CRUD =====");
                Console.WriteLine("1. Insert Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertEmployee();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
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

        // Create
        static void InsertEmployee()
        {
            using (AppDbContext db = new AppDbContext())
            {
                Employee emp = new Employee();

                Console.Write("Enter Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("Enter Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                db.Employees.Add(emp);
                db.SaveChanges();

                Console.WriteLine("Employee Added Successfully!\n");
            }
        }

        // Read
        static void ViewEmployees()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var employees = db.Employees.ToList();

                Console.WriteLine("\n===== Employee Records =====");

                foreach (var emp in employees)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("ID         : " + emp.Id);
                    Console.WriteLine("Name       : " + emp.Name);
                    Console.WriteLine("Department : " + emp.Department);
                    Console.WriteLine("Salary     : " + emp.Salary);
                }

                Console.WriteLine();
            }
        }

        // Update
        static void UpdateEmployee()
        {
            using (AppDbContext db = new AppDbContext())
            {
                Console.Write("Enter Employee ID to Update: ");
                int id = Convert.ToInt32(Console.ReadLine());

                var emp = db.Employees.Find(id);

                if (emp != null)
                {
                    Console.Write("Enter New Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Enter New Department: ");
                    emp.Department = Console.ReadLine();

                    Console.Write("Enter New Salary: ");
                    emp.Salary = Convert.ToDouble(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Employee Updated Successfully!\n");
                }
                else
                {
                    Console.WriteLine("Employee Not Found!\n");
                }
            }
        }

        // Delete
        static void DeleteEmployee()
        {
            using (AppDbContext db = new AppDbContext())
            {
                Console.Write("Enter Employee ID to Delete: ");
                int id = Convert.ToInt32(Console.ReadLine());

                var emp = db.Employees.Find(id);

                if (emp != null)
                {
                    db.Employees.Remove(emp);
                    db.SaveChanges();

                    Console.WriteLine("Employee Deleted Successfully!\n");
                }
                else
                {
                    Console.WriteLine("Employee Not Found!\n");
                }
            }
        }
    }
}

