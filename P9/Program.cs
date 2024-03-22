using System;

class Complex
{
    public readonly double real;
    public readonly double imaginary;

    public Complex(double real, double imaginary) => (this.real, this.imaginary) = (real, imaginary);

    public static Complex operator +(Complex c1, Complex c2) => new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);

    public void Display() => Console.WriteLine($"Result: {real} + {imaginary}i");
}

class Program
{
    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }

    static void DisplayComplex(Complex complex, string message) => Console.WriteLine($"{message}: {complex.real} + {complex.imaginary}i");

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

        DisplayComplex(complex1, "First complex number");
        DisplayComplex(complex2, "Second complex number");
        DisplayComplex(result, "Result of addition");
    }
}
