using System;

class Program
{
    // 1. Function to add two numbers
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // 2. Function to multiply two numbers
    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        // 3. Get input from the user
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        // 4. Call the functions and display results
        int sum = AddNumbers(num1, num2);
        int product = MultiplyNumbers(num1, num2);

        Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
        Console.WriteLine($"Product of {num1} and {num2} is {product}");
    }
}
