using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    private readonly double radius;

    public Circle(double radius) => this.radius = radius;

    public override double CalculateArea() => Math.PI * radius * radius;

    public override double CalculatePerimeter() => 2 * Math.PI * radius;
}

class Triangle : Shape
{
    private readonly double side1, side2, side3;

    public Triangle(double side1, double side2, double side3) => (this.side1, this.side2, this.side3) = (side1, side2, side3);

    public override double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double CalculatePerimeter() => side1 + side2 + side3;
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
        double circleRadius = ReadDouble("Enter the radius of the circle: ");
        Circle circle = new Circle(circleRadius);

        Console.WriteLine("Enter the side lengths of the triangle (separated by spaces):");
        string[] triangleSides = Console.ReadLine().Split(' ');
        double side1 = Convert.ToDouble(triangleSides[0]);
        double side2 = Convert.ToDouble(triangleSides[1]);
        double side3 = Convert.ToDouble(triangleSides[2]);
        Triangle triangle = new Triangle(side1, side2, side3);

        Console.WriteLine($"\nCircle - Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");
        Console.WriteLine($"Triangle - Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
    }
}
