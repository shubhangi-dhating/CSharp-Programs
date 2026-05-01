// Console-based Role-based Authentication System in C#

using System;
using System.Collections.Generic;
using System.Linq;

namespace RoleBasedAuthSystem
{
    // User Model
    class User
    {
        public string Username;
        public string Password;
        public string Role;
    }

    class Program
    {
        static List<User> users = new List<User>();

        static void Main()
        {
            SeedUsers();

            while (true)
            {
                Console.WriteLine("\n===== ROLE-BASED AUTHENTICATION SYSTEM =====");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");
                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }

        static void SeedUsers()
        {
            users.Add(new User { Username = "admin", Password = "admin123", Role = "Admin" });
            users.Add(new User { Username = "manager", Password = "manager123", Role = "Manager" });
            users.Add(new User { Username = "employee", Password = "employee123", Role = "Employee" });
        }

        static void Login()
        {
            Console.Write("\nEnter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            User user = users.FirstOrDefault
            (
                u => u.Username == username && u.Password == password
            );

            if (user != null)
            {
                Console.WriteLine($"\nLogin Successful! Welcome {user.Username}");
                ShowDashboard(user);
            }
            else
            {
                Console.WriteLine("Invalid Username or Password!");
            }
        }

        static void ShowDashboard(User user)
        {
            switch (user.Role)
            {
                case "Admin":
                    AdminPanel();
                    break;

                case "Manager":
                    ManagerPanel();
                    break;

                case "Employee":
                    EmployeePanel();
                    break;

                default:
                    Console.WriteLine("Unauthorized Access!");
                    break;
            }
        }

        // ---------------- Admin ----------------
        static void AdminPanel()
        {
            Console.WriteLine("\n===== ADMIN DASHBOARD =====");
            Console.WriteLine("1. Manage Users");
            Console.WriteLine("2. View Reports");
            Console.WriteLine("3. System Settings");
        }

        // ---------------- Manager ----------------
        static void ManagerPanel()
        {
            Console.WriteLine("\n===== MANAGER DASHBOARD =====");
            Console.WriteLine("1. Manage Team");
            Console.WriteLine("2. Approve Requests");
            Console.WriteLine("3. View Performance");
        }

        // ---------------- Employee ----------------
        static void EmployeePanel()
        {
            Console.WriteLine("\n===== EMPLOYEE DASHBOARD =====");
            Console.WriteLine("1. View Profile");
            Console.WriteLine("2. Apply Leave");
            Console.WriteLine("3. View Salary");
        }
    }
}

