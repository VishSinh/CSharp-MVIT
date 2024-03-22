using System;

class StackImplementation
{
    static void Main()
    {
        var stack = new Stack();
        
        while (true)
        {
            Console.WriteLine("\nChoose an option:\n1. Push\n2. Pop\n3. Display\n4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the value to push:");
                    int value = Convert.ToInt32(Console.ReadLine());
                    stack.Push(value);
                    break;

                case 2:
                    int poppedValue = stack.Pop();
                    if (poppedValue != -1)
                        Console.WriteLine($"Popped element: {poppedValue}");
                    break;

                case 3:
                    stack.Display();
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}

class Stack
{
    const int MaxSize = 10;
    readonly int[] items = new int[MaxSize];
    int top = -1;

    public void Push(int value)
    {
        if (top == MaxSize - 1)
            Console.WriteLine("Stack overflow! Cannot push more elements.");
        else
        {
            items[++top] = value;
            Console.WriteLine($"Element {value} pushed successfully.");
        }
    }

    public int Pop() {
        if (top == -1)
        {
            Console.WriteLine("Stack underflow! Cannot pop more elements.");
            return -1;
        }
        return items[top--];
    }

    public void Display()
    {
        if (top == -1)
            Console.WriteLine("Stack is empty.");
        else
        {
            Console.WriteLine("Stack elements:");
            for (int i = top; i >= 0; i--)
                Console.Write($"{items[i]} ");
                
        }
    }
}
