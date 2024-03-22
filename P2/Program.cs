using System;

class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers between 1 and 1000:");

        for (int number = 1; number <= 1000; number++)
        {
            int sum = 0;
            int temp = number;
            int numDigits = (int)Math.Ceiling(Math.Log10(temp));

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numDigits);
                temp /= 10;
            }

            if (number == sum)
                Console.WriteLine(number);
        }
    }
}
