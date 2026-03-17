using System;
class OperatorDemo
{
    public static void Main(string[] args)

    {
        Console.WriteLine("Arithmatic Operators....");

        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second Number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        //Arithmatic operators
        Console.WriteLine("Addition of Two Numbers:"+ (num1+num2));
        Console.WriteLine("Subtraction of Two Numbers:" +(num1-num2));
        Console.WriteLine("Multiplication of Two Numbers:"+(num1*num2));
        Console.WriteLine("Division of Two Numbers:"+(num1/num2));

        //Relational Operators
        Console.WriteLine("\n Relational operators...");
        Console.WriteLine("Num1 is greater than Num2" + (num1 > num2));
        Console.WriteLine("Num1 is less than Num2" + (num1 < num2));
      //  Console.WriteLine("Num1 is equal to num2", + (num1  == num2));
        Console.WriteLine("Num1 is not equal to Num2" + (num1 != num2));

        //Logical Operators
        Console.WriteLine("\nLogical Operators");
        Console.WriteLine("(num1 > 0 && num2 > 0) : " + (num1 > 0 && num2 > 0));
        Console.WriteLine("(num1 > 0 || num2 < 0) : " + (num1 > 0 || num2 < 0));
        Console.WriteLine("!(num1 > num2) : " + !(num1 > num2));

        // Assignment Operators
        Console.WriteLine("\nAssignment Operators");
        int c = num1;
        Console.WriteLine("c = num1 : " + c);

        c += num2;
        Console.WriteLine("c += num2 : " + c);

        c -= num2;
        Console.WriteLine("c -= num2 : " + c);

        // Unary Operators
        Console.WriteLine("\nUnary Operators");
        Console.WriteLine("num1++ : " + (num1++));
        Console.WriteLine("After increment num1 : " + num1);

        Console.WriteLine("--num2 : " + (--num2));

    }
}