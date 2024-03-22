using System;

class SubstringLister
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        Console.WriteLine("All substrings in the given string:");

        for (int i = 0; i < inputString.Length; i++)
            for (int j = 1; j <= inputString.Length - i; j++)
            {
                string substring = inputString.Substring(i, j);
                Console.WriteLine(substring);
            }
    }
}
