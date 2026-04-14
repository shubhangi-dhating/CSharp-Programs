using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Convert to lowercase
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        // Convert to char arrays
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        // Sort arrays
        Array.Sort(arr1);
        Array.Sort(arr2);

        // Check length first
        if (arr1.Length != arr2.Length)
        {
            Console.WriteLine("Strings are NOT Anagrams");
            return;
        }

        // Compare characters
        bool isAnagram = true;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isAnagram = false;
                break;
            }
        }

        // Output result
        if (isAnagram)
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}