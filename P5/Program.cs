using System;

class PascalTriangle
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for Pascal's Triangle:");
        int numRows = Convert.ToInt32(Console.ReadLine());

        int[,] triangle = new int[numRows, numRows];

        for (int i = 0; i < numRows; i++)
            for (int j = 0; j <= i; j++)
                triangle[i, j] = (j == 0 || j == i) ? 1 : triangle[i - 1, j - 1] + triangle[i - 1, j];
           

        Console.WriteLine("Pascal's Triangle:");

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write($"{triangle[i, j]} ");
            Console.WriteLine();
        }
    }
}
