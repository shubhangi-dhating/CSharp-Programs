using System;

class CountWords
{
    static void Main(string[] args)
    {
        // Input string
        Console.Write("Enter a String: ");
        string str = Console.ReadLine();

        // ==============================
        //       COUNT WORDS
        // ==============================
        int wordCount = 0;
        int charCount = 0;
        int spaceCount = 0;
        int sentenceCount = 0;
        bool inWord = false;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            // Count characters (excluding spaces)
            if (ch != ' ')
                charCount++;

            // Count spaces
            if (ch == ' ')
            {
                spaceCount++;
                inWord = false;
            }
            else if (!inWord)
            {
                wordCount++;
                inWord = true;
            }

            // Count sentences
            if (ch == '.' || ch == '!' || ch == '?')
                sentenceCount++;
        }

        // ==============================
        //       DISPLAY RESULT
        // ==============================
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Input String     : " + str);
        Console.WriteLine("Total Words      : " + wordCount);
        Console.WriteLine("Total Characters : " + charCount);
        Console.WriteLine("Total Spaces     : " + spaceCount);
        Console.WriteLine("Total Sentences  : " + sentenceCount);
        Console.WriteLine("Average Word Len : " +
                         (wordCount > 0 ?
                         ((double)charCount / wordCount).ToString("F2")
                         : "0"));

        // Display each word
        Console.WriteLine("\n--- Words Found ---");
        string[] words = str.Split(new char[] { ' ' },
                         StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
            Console.WriteLine("Word " + (i + 1) + " : " + words[i]);
    }
}