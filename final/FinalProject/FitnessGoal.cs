using System;

// Derived class for tracking user's fitness goals
public class FitnessGoal : UserProfile
{
    public string GoalDescription { get; set; }
    public int TargetSteps { get; set; }

    public void DisplayGoal()
    {
        Console.WriteLine($"Goal: {GoalDescription}\nTarget Steps: {TargetSteps}");
    }
}