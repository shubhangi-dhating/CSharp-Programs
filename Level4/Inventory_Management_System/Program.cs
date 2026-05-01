// Console-based Inventory Management System in C#

using System;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public double Price;
    public int Quantity;
}

class Inventory
{
    List<Product> products = new List<Product>();

    public void AddProduct()
    {
        Product p = new Product();

        Console.Write("Enter Product ID: ");
        p.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Product Price: ");
        p.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Product Quantity: ");
        p.Quantity = Convert.ToInt32(Console.ReadLine());

        products.Add(p);
        Console.WriteLine("Product Added Successfully!\n");
    }

    public void ViewProducts()
    {
        Console.WriteLine("\n===== Product List =====");

        foreach (Product p in products)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID       : " + p.Id);
            Console.WriteLine("Name     : " + p.Name);
            Console.WriteLine("Price    : " + p.Price);
            Console.WriteLine("Quantity : " + p.Quantity);
        }

        Console.WriteLine();
    }

    public void UpdateStock()
    {
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Product p in products)
        {
            if (p.Id == id)
            {
                Console.Write("Enter New Quantity: ");
                p.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Stock Updated Successfully!\n");
                return;
            }
        }

        Console.WriteLine("Product Not Found!\n");
    }

    public void DeleteProduct()
    {
        Console.Write("Enter Product ID to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Id == id)
            {
                products.RemoveAt(i);
                Console.WriteLine("Product Deleted Successfully!\n");
                return;
            }
        }

        Console.WriteLine("Product Not Found!\n");
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();
        int choice;

        do
        {
            Console.WriteLine("===== Inventory Management System =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Stock");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    inventory.AddProduct();
                    break;
                case 2:
                    inventory.ViewProducts();
                    break;
                case 3:
                    inventory.UpdateStock();
                    break;
                case 4:
                    inventory.DeleteProduct();
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
