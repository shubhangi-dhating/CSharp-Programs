using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;

class StudentGrade
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Student Grade Calculator ===\n");

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter number of subjects: ");
        int numSubjects = int.Parse(Console.ReadLine());

        double totalMarks = 0;

        for (int i = 1; i <= numSubjects; i++)
        {
            Console.Write($"Enter marks for Subject {i} (out of 100): ");
            double marks = double.Parse(Console.ReadLine());
            totalMarks += marks;
        }

        double percentage = totalMarks / numSubjects;
        string grade = GetGrade(percentage);
        string remarks = GetRemarks(grade);

        Console.WriteLine("\n========== Result ==========");
        Console.WriteLine($"Student Name : {name}");
        Console.WriteLine($"Total Marks  : {totalMarks} / {numSubjects * 100}");
        Console.WriteLine($"Percentage   : {percentage:F2}%");
        Console.WriteLine($"Grade        : {grade}");
        Console.WriteLine($"Remarks      : {remarks}");
        Console.WriteLine("============================");
    }

    static string GetGrade(double percentage)
    {
        if (percentage >= 90) return "A+";
        else if (percentage >= 80) return "A";
        else if (percentage >= 70) return "B";
        else if (percentage >= 60) return "C";
        else if (percentage >= 50) return "D";
        else return "F";
    }

    static string GetRemarks(string grade)
    {
        return grade switch
        {
            "A+" => "Outstanding!",
            "A" => "Excellent!",
            "B" => "Very Good",
            "C" => "Good",
            "D" => "Pass",
            "F" => "Fail - Needs Improvement",
            _ => "Unknown"
        };
    }
}

