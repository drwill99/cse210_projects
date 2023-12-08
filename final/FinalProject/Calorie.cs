using System;

public class Calorie
{
    public double CaloriesBurned { get; set; }

    public void DisplayCalories()
    {
        Console.WriteLine($"Calories Burned: {CaloriesBurned} kcal");
    }

    
}