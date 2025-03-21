using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // 2. Add elements to the list
        numbers.Add(6);
        numbers.Add(7);

        // 3. Remove an element from the list
        numbers.Remove(3);

        // 4. Access elements in the list
        Console.WriteLine("Numbers in the list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // 5. Get the count of elements in the list
        Console.WriteLine($"Total numbers in the list: {numbers.Count}");
    }
}
