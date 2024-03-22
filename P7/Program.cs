using System;
using System.IO;

class FileCopy
{
    static void Main()
    {
        Console.WriteLine("Enter the path of the source text file:");
        string sourceFilePath = Console.ReadLine();

        Console.WriteLine("Enter the path of the destination text file:");
        string destinationFilePath = Console.ReadLine();

        try
        {
            File.WriteAllText(destinationFilePath, File.ReadAllText(sourceFilePath));
            Console.WriteLine("File copy successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
