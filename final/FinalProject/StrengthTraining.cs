using System;

// Derived class for strength training activities
public class StrengthTraining : Activity
{
    public int Weight { get; set; }
    public int Sets { get; set; }
    public int Repetitions { get; set; }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Sets: {Sets}\nRepetitions: {Repetitions}");
    }

    
}