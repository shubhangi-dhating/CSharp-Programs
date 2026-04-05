using System;

class CharacterFrequency
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String: ");
        string str = Console.ReadLine().ToLower();

        // Array for 26 alphabets
        int[] freq = new int[26];

        foreach (char ch in str)
            if (ch >= 'a' && ch <= 'z')
                freq[ch - 'a']++;

        Console.WriteLine("\n--- Alphabet Frequency ---");
        Console.WriteLine("{0,-10} {1}", "Character", "Frequency");
        Console.WriteLine(new string('-', 25));

        for (int i = 0; i < 26; i++)
            if (freq[i] > 0)
                Console.WriteLine("{0,-10} {1}",
                                  (char)('a' + i),
                                  freq[i]);
    }
}
