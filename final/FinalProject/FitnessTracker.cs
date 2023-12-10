using System;

public class FitnessTracker
{
    private List<Activity> activities;

    public FitnessTracker()
    {
        activities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        activities.Add(activity);
    }

    public void DisplayActivities()
    {
        foreach (var activity in activities)
        {
            activity.DisplayDetails();
            Console.WriteLine("---------------------------");
        }
    }
}