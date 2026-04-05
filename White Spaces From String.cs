using System;

class RemoveWhiteSpaces
{
    static void Main(string[] args)
    {
        // Input string
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();

        // ==============================
        //    REMOVE WHITE SPACES
        // ==============================
        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
                result += str[i];
        }

        // ==============================
        //       DISPLAY RESULT
        // ==============================
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Original String  : " + str);
        Console.WriteLine("Modified String  : " + result);
        Console.WriteLine("Original Length  : " + str.Length);
        Console.WriteLine("Modified Length  : " + result.Length);
        Console.WriteLine("Spaces Removed   : " + (str.Length - result.Length));
    }
}