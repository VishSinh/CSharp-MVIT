using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Arithmetic Calculator");

        Console.Write("Enter the operator (+, -, *, /, %): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); 

        Console.Write("Enter the first operand: ");
        double operand1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second operand: ");
        double operand2 = Convert.ToDouble(Console.ReadLine());

        double result = operation switch
        {
            '+' => operand1 + operand2,
            '-' => operand1 - operand2,
            '*' => operand1 * operand2,
            '/' => operand2 != 0 ? operand1 / operand2 : throw new DivideByZeroException("Error: Division by zero."),
            '%' => operand2 != 0 ? operand1 % operand2 : throw new DivideByZeroException("Error: Division by zero."),
            _ => throw new InvalidOperationException("Error: Invalid operator.")
        };

        Console.WriteLine($"Result: {operand1} {operation} {operand2} = {result}");
    }
}
