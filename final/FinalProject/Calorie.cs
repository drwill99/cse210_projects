using System;

// Additional class for calorie tracking
public class Calorie
{
    public double CaloriesBurned { get; set; }

    public void DisplayCalories()
    {
        Console.WriteLine($"Calories Burned: {CaloriesBurned} kcal");
    }

    
}