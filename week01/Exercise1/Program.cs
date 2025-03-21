using System;

class Program
{
    static void Main()
    {
        // 1. Declare variables
        string name;
        int age;

        // 2. Get input from user
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        age = int.Parse(Console.ReadLine());

        // 3. Output the result
        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }
}
