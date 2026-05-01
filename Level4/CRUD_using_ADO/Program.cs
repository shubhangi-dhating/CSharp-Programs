// Database CRUD using ADO.NET in C#
// SQL Server Table: Employee(Id INT PRIMARY KEY, Name VARCHAR(50), Department VARCHAR(50), Salary FLOAT)

using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
        "Data Source=.;Initial Catalog=CompanyDB;Integrated Security=True";

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("===== ADO.NET CRUD Application =====");
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
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

        } while (choice != 5);
    }

    // Insert
    static void InsertEmployee()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Employee VALUES (@Id,@Name,@Dept,@Salary)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Dept", dept);
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Inserted Successfully!\n");
        }
    }

    // Read
    static void ViewEmployees()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("\n===== Employee Records =====");

            while (dr.Read())
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("ID         : " + dr["Id"]);
                Console.WriteLine("Name       : " + dr["Name"]);
                Console.WriteLine("Department : " + dr["Department"]);
                Console.WriteLine("Salary     : " + dr["Salary"]);
            }

            Console.WriteLine();
        }
    }

    // Update
    static void UpdateEmployee()
    {
        Console.Write("Enter Employee ID to Update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter New Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter New Department: ");
        string dept = Console.ReadLine();

        Console.Write("Enter New Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query =
                "UPDATE Employee SET Name=@Name, Department=@Dept, Salary=@Salary WHERE Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Dept", dept);
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("Employee Updated Successfully!\n");
            else
                Console.WriteLine("Employee Not Found!\n");
        }
    }

    // Delete
    static void DeleteEmployee()
    {
        Console.Write("Enter Employee ID to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Employee WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("Employee Deleted Successfully!\n");
            else
                Console.WriteLine("Employee Not Found!\n");
        }
    }
}

