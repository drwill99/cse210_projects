// EternalGoal class for goals that are never complete
public class EternalGoal : Goal // EternalGoal inherits from base class Goal
{
    // Constructor to initialize EternalGoal with name and value
    public EternalGoal(string name, int value)
    {
        _name = name;
        _value = value;
    }

    // Override method to display status of eternal goal
    public override void DisplayStatus() // Overrides DisplayStatus method from base class Goal
    {
        // Display eternal goal name and value
        Console.WriteLine($"Eternal Goal: {_name} (Value: {_value})");
    }

    // Override method to record an event for eternal goal
    public override void RecordEvent() // Overrides RecordEvent method from base class Goal
    {
        // Display message indicating the eternal goal event is recorded and points earned
        Console.WriteLine($"Event recorded: {_name}! +{_value} points");
    }
}