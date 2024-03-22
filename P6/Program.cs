using System;

class FloydsTriangle
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for Floyd's Triangle:");
        int numRows = Convert.ToInt32(Console.ReadLine());

        int[,] triangle = new int[numRows, numRows];

        int currentNumber = 1;
        for (int i = 0; i < numRows; i++)
            for (int j = 0; j <= i; j++)
                triangle[i, j] = currentNumber++;


        Console.WriteLine("Floyd's Triangle:");

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write($"{triangle[i, j]} ");
            Console.WriteLine();
        }
    }
}
