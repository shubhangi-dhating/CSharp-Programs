using System;

class PalindromeString
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String: ");
        string str = Console.ReadLine().ToLower();

        // Reverse the string
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);

        Console.WriteLine("\nOriginal String : " + str);
        Console.WriteLine("Reversed String : " + reversed);

        if (str == reversed)
            Console.WriteLine("Result          : String is  PALINDROME!");
        else
            Console.WriteLine("Result          : ❌ NOT a Palindrome!");
    }
}
