using System;

// Base class representing a general activity
public class Activity
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Activity: {Name}\nStart Time: {StartTime}\nEnd Time: {EndTime}");
    }

    
}