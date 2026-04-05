using System;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();

        // Convert to char array and reverse
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);

        string reversed = new string(chars);

        Console.WriteLine("Original String : " + str);
        Console.WriteLine("Reversed String : " + reversed);
    }
}