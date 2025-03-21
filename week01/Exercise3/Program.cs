using System;

class Program
{
    static void Main()
    {
        // 1. Print numbers 1 to 10 using a for loop
        Console.WriteLine("Using for loop:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // 2. Print numbers 1 to 10 using a while loop
        Console.WriteLine("Using while loop:");
        int counter = 1;
        while (counter <= 10)
        {
            Console.WriteLine(counter);
            counter++;
        }

        // 3. Print numbers 1 to 10 using a foreach loop
        Console.WriteLine("Using foreach loop:");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
