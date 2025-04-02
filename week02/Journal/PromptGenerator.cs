

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        
                Journal journal = new Journal();
        bool exit = false;
        
        while (!exit)
        {
            // Display menu
            DisplayMenu();
            
            // Get user choice
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            
            // Process user choice
            switch (choice)
            {
                case "1":
                    // Write a new entry
                    journal.AddEntry();
                    break;
                    
                case "2":
                    // Display journal
                    journal.Display();
                    break;
                    
                case "3":
                    // Save journal to file
                    journal.SaveToFile(string file);
                    break;
                    
                case "4":
                    // Load journal from file
                    journal.LoadFromFile();
                    break;
                    
                case "5":
                    // Exit
                    exit = true;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;
                    
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            
            // Add a line break for better readability
            Console.WriteLine();
        }
    }
    
    static void DisplayMenu()
    {
        Console.WriteLine("===== Journal Program =====");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }
}

/*
# Exceeding Requirements:
# 1. Added five additional meaningful prompts beyond the minimum required five
# 2. Implemented robust error handling in file operations
# 3. Created a more user-friendly display format for entries
# 4. Added validation when loading entries to ensure proper formatting
# 5. Used proper encapsulation with private fields and public properties
*/
       