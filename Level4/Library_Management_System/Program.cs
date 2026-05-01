// Console-based Library Management System in C#

using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
    public string Author;
    public bool IsIssued;
}

class Library
{
    List<Book> books = new List<Book>();

    public void AddBook()
    {
        Book b = new Book();

        Console.Write("Enter Book ID: ");
        b.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Title: ");
        b.Title = Console.ReadLine();

        Console.Write("Enter Author: ");
        b.Author = Console.ReadLine();

        b.IsIssued = false;
        books.Add(b);

        Console.WriteLine("Book Added Successfully!\n");
    }

    public void ViewBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (Book b in books)
        {
            Console.WriteLine($"ID: {b.Id}, Title: {b.Title}, Author: {b.Author}, Issued: {b.IsIssued}");
        }
        Console.WriteLine();
    }

    public void IssueBook()
    {
        Console.Write("Enter Book ID to Issue: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Book b in books)
        {
            if (b.Id == id && !b.IsIssued)
            {
                b.IsIssued = true;
                Console.WriteLine("Book Issued Successfully!\n");
                return;
            }
        }

        Console.WriteLine("Book not available.\n");
    }

    public void ReturnBook()
    {
        Console.Write("Enter Book ID to Return: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Book b in books)
        {
            if (b.Id == id && b.IsIssued)
            {
                b.IsIssued = false;
                Console.WriteLine("Book Returned Successfully!\n");
                return;
            }
        }

        Console.WriteLine("Invalid Book ID.\n");
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();
        int choice;

        do
        {
            Console.WriteLine("===== Library Management System =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Issue Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    lib.AddBook();
                    break;
                case 2:
                    lib.ViewBooks();
                    break;
                case 3:
                    lib.IssueBook();
                    break;
                case 4:
                    lib.ReturnBook();
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
