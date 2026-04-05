using System;

class CountVowels
{
    static void Main(string[] args)
    {
        // Input string
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();

        // ==============================
        //       COUNT VOWELS
        // ==============================
        int vowelCount = 0;
        int consonantCount = 0;
        int digitCount = 0;
        int spaceCount = 0;
        int specialCount = 0;

        string vowels = "aeiouAEIOU";

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (vowels.Contains(ch))
                vowelCount++;
            else if (char.IsLetter(ch))
                consonantCount++;
            else if (char.IsDigit(ch))
                digitCount++;
            else if (ch == ' ')
                spaceCount++;
            else
                specialCount++;
        }

        // ==============================
        //       DISPLAY RESULT
        // ==============================
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Input String     : " + str);
        Console.WriteLine("Total Length     : " + str.Length);
        Console.WriteLine("Vowels           : " + vowelCount);
        Console.WriteLine("Consonants       : " + consonantCount);
        Console.WriteLine("Digits           : " + digitCount);
        Console.WriteLine("Spaces           : " + spaceCount);
        Console.WriteLine("Special Chars    : " + specialCount);

        // Display vowels found
        Console.Write("\nVowels Found     : ");
        foreach (char ch in str)
            if (vowels.Contains(ch))
                Console.Write(ch + " ");
        Console.WriteLine();
    }
}
