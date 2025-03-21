using System;

class Program
{
    static void Main()
    {
        // 1. Get user input
        Console.WriteLine("Enter your score:");
        int score = int.Parse(Console.ReadLine());

        // 2. Conditional statements to categorize score
        if (score >= 90)
        {
            Console.WriteLine("You got an A.");
        }
        else if (score >= 80)
        {
            Console.WriteLine("You got a B.");
        }
        else if (score >= 70)
        {
            Console.WriteLine("You got a C.");
        }
        else if (score >= 60)
        {
            Console.WriteLine("You got a D.");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
    }
}
