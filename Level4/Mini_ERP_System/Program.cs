// Console-based Mini ERP System in C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniERP
{
    // Product Model
    class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public int Stock;
    }

    // Employee Model
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }

    // Customer Order Model
    class Order
    {
        public int OrderId;
        public string CustomerName;
        public string ProductName;
        public int Quantity;
        public double TotalAmount;
    }

    class Program
    {
        static List<Product> products = new List<Product>();
        static List<Employee> employees = new List<Employee>();
        static List<Order> orders = new List<Order>();

        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== MINI ERP SYSTEM =====");
                Console.WriteLine("1. Product Management");
                Console.WriteLine("2. Employee Management");
                Console.WriteLine("3. Sales / Orders");
                Console.WriteLine("4. Reports");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ProductMenu();
                        break;
                    case 2:
                        EmployeeMenu();
                        break;
                    case 3:
                        OrderMenu();
                        break;
                    case 4:
                        ReportsMenu();
                        break;
                    case 5:
                        Console.WriteLine("Exiting ERP...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 5);
        }

        // ---------------- Product Module ----------------
        static void ProductMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Product Management ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Update Stock");
                Console.WriteLine("4. Back");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        ViewProducts();
                        break;
                    case 3:
                        UpdateStock();
                        break;
                }

            } while (choice != 4);
        }

        static void AddProduct()
        {
            Product p = new Product();

            Console.Write("Enter Product ID: ");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            products.Add(p);
            Console.WriteLine("Product Added!");
        }

        static void ViewProducts()
        {
            Console.WriteLine("\nProduct List:");
            foreach (var p in products)
            {
                Console.WriteLine($"ID:{p.Id} Name:{p.Name} Price:{p.Price} Stock:{p.Stock}");
            }
        }

        static void UpdateStock()
        {
            Console.Write("Enter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var p = products.FirstOrDefault(x => x.Id == id);

            if (p != null)
            {
                Console.Write("Enter New Stock: ");
                p.Stock = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Stock Updated!");
            }
            else
            {
                Console.WriteLine("Product Not Found!");
            }
        }

        // ---------------- Employee Module ----------------
        static void EmployeeMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Employee Management ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Back");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                }

            } while (choice != 3);
        }

        static void AddEmployee()
        {
            Employee e = new Employee();

            Console.Write("Enter Employee ID: ");
            e.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            e.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            e.Department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            e.Salary = Convert.ToDouble(Console.ReadLine());

            employees.Add(e);
            Console.WriteLine("Employee Added!");
        }

        static void ViewEmployees()
        {
            Console.WriteLine("\nEmployee List:");
            foreach (var e in employees)
            {
                Console.WriteLine($"ID:{e.Id} Name:{e.Name} Dept:{e.Department} Salary:{e.Salary}");
            }
        }

        // ---------------- Orders Module ----------------
        static void OrderMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Sales / Orders ---");
                Console.WriteLine("1. Create Order");
                Console.WriteLine("2. View Orders");
                Console.WriteLine("3. Back");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateOrder();
                        break;
                    case 2:
                        ViewOrders();
                        break;
                }

            } while (choice != 3);
        }

        static void CreateOrder()
        {
            Order o = new Order();

            Console.Write("Enter Order ID: ");
            o.OrderId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            o.CustomerName = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            o.ProductName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            o.Quantity = Convert.ToInt32(Console.ReadLine());

            var p = products.FirstOrDefault(x => x.Name == o.ProductName);

            if (p != null && p.Stock >= o.Quantity)
            {
                o.TotalAmount = p.Price * o.Quantity;
                p.Stock -= o.Quantity;
                orders.Add(o);

                Console.WriteLine("Order Created Successfully!");
            }
            else
            {
                Console.WriteLine("Product Not Available / Insufficient Stock!");
            }
        }

        static void ViewOrders()
        {
            Console.WriteLine("\nOrders List:");
            foreach (var o in orders)
            {
                Console.WriteLine($"OrderID:{o.OrderId} Customer:{o.CustomerName} Product:{o.ProductName} Qty:{o.Quantity} Total:{o.TotalAmount}");
            }
        }

        // ---------------- Reports Module ----------------
        static void ReportsMenu()
        {
            Console.WriteLine("\n--- Reports ---");
            Console.WriteLine("Total Products : " + products.Count);
            Console.WriteLine("Total Employees: " + employees.Count);
            Console.WriteLine("Total Orders   : " + orders.Count);
            Console.WriteLine("Total Sales    : " + orders.Sum(x => x.TotalAmount));
        }
    }
}

