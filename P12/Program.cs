using System;

interface Resizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

class Rectangle : Resizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height) => (this.width, this.height) = (width, height);

    public void Display() => Console.WriteLine($"Rectangle - Width: {width}, Height: {height}");

    public void ResizeWidth(int newWidth) => Console.WriteLine($"Resized width to {width = newWidth}");

    public void ResizeHeight(int newHeight) => Console.WriteLine($"Resized height to {height = newHeight}");
}

class Program
{
    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main()
    {
        int initialWidth = ReadInt("Enter the initial width of the rectangle: ");
        int initialHeight = ReadInt("Enter the initial height of the rectangle: ");
        Rectangle rectangle = new Rectangle(initialWidth, initialHeight);

        Console.WriteLine("\nOriginal Size:");
        rectangle.Display();

        int newWidth = ReadInt("\nEnter the new width for resizing: ");
        rectangle.ResizeWidth(newWidth);

        int newHeight = ReadInt("Enter the new height for resizing: ");
        rectangle.ResizeHeight(newHeight);

        Console.WriteLine("\nUpdated Size:");
        rectangle.Display();
    }
}
