using System;

public class Job
{
    // Member variables for the job class
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display job details
    public void Display()
    {
        // Format and display the job details
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
