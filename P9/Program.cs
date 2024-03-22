using System;

class Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex c1, Complex c2) =>
        new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);

    public void Display() => Console.WriteLine($"Result: {Real} + {Imaginary}i");
}

class Program
{
    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }

    static void Main()
    {
        Console.WriteLine("Enter the first complex number:");
        double real1 = ReadDouble("Real part: ");
        double imaginary1 = ReadDouble("Imaginary part: ");

        Console.WriteLine("\nEnter the second complex number:");
        double real2 = ReadDouble("Real part: ");
        double imaginary2 = ReadDouble("Imaginary part: ");

        Complex complex1 = new Complex(real1, imaginary1);
        Complex complex2 = new Complex(real2, imaginary2);

        Complex result = complex1 + complex2;

        Console.WriteLine("\nFirst complex number:");
        complex1.Display();
        Console.WriteLine("\nSecond complex number:");
        complex2.Display();
        Console.WriteLine("\nResult of addition:");
        result.Display();
    }
}
