using System;

class ReplaceSubstring
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String       : ");
        string str = Console.ReadLine();

        Console.Write("Enter word to Find   : ");
        string find = Console.ReadLine();

        Console.Write("Enter word to Replace: ");
        string replace = Console.ReadLine();

        // Built-in Replace
        string result = str.Replace(find, replace);

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Original String  : " + str);
        Console.WriteLine("Modified String  : " + result);
    }
}
