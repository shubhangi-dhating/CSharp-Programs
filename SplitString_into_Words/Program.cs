using System;

class Program
{
    static void Main()
    {
        string sentence = "C sharp is a powerful language";

        // Splitting string into words
        string[] words = sentence.Split(' ');

        Console.WriteLine("Words in the string are:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
