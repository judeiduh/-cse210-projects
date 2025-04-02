using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables for the resume class
    public string _name;
    public List<Job> _jobs;

    // Constructor to initialize the list of jobs
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>(); // Initialize the list of jobs
    }

    // Method to display the resume details
    public void Display()
    {
        // Display the person's name
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Display each job's details using the Display method from the Job class
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
