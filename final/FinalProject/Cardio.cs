using System;

public class Cardio : Activity
{
    public int HeartRate { get; set; }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Heart Rate: {HeartRate} bpm");
    }

    
}
