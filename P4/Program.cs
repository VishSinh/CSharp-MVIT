using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            int numerator = 10;
            int denominator = 3;
            int result = numerator / denominator;
            Console.WriteLine($"Result of division of {numerator}/{denominator}: {result}");
            
            numerator = 10;
            denominator = 0;
            result = numerator / denominator;
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Division by zero exception caught: {ex.Message}");
        }

        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 3;
            int value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");            
            
            index = 10;
            value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Specified Index is out of range hence out of range exception caught: {ex.Message}");
        }
    }
}
