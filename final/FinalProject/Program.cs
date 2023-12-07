using System;

class Program
{
    static void Main()
    {
        Cardio cardio = new Cardio();
        Console.WriteLine("Enter details for Cardio Activity");
        cardio.Name = PromptForString("Exercise");
        cardio.StartTime = PromptForDateTime("Start Time");
        cardio.EndTime = PromptForDateTime("End Time");
        cardio.HeartRate = PromptForInt("Heart Rate");

        StrengthTraining strength = new StrengthTraining();
        Console.WriteLine("\nEnter details for Strength Training Activity");
        strength.Name = PromptForString("Name");
        strength.StartTime = PromptForDateTime("Start Time");
        strength.EndTime = PromptForDateTime("End Time");
        strength.Sets = PromptForInt("Sets");
        strength.Repetitions = PromptForInt("Repetitions");

        FitnessTracker tracker = new FitnessTracker();
        tracker.AddActivity(cardio);
        tracker.AddActivity(strength);

        Console.WriteLine("\nActivities Entered:");
        tracker.DisplayActivities();

        Calorie calorieTracker = new Calorie();
        Console.WriteLine("\nEnter details for Calorie Tracker");
        calorieTracker.CaloriesBurned = PromptForDouble("Calories Burned");

        Console.WriteLine("\nCalories Entered:");
        calorieTracker.DisplayCalories();
    }

    static string PromptForString(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine();
    }

    static DateTime PromptForDateTime(string prompt)
    {
        Console.Write($"{prompt} (yyyy-MM-dd HH:mm): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Using current time.");
            return DateTime.Now;
        }
    }

    static int PromptForInt(string prompt)
    {
        Console.Write($"{prompt}: ");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default value (0).");
            return 0;
        }
    }

    static double PromptForDouble(string prompt)
    {
        Console.Write($"{prompt}: ");
        if (double.TryParse(Console.ReadLine(), out double result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default value (0).");
            return 0;
        }


    }


}