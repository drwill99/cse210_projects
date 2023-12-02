// SimpleGoal class for goals that can be marked complete
public class SimpleGoal : Goal // Inherits from the base class Goal
{
    // Constructor to initialize a SimpleGoal with a name and value
    public SimpleGoal(string name, int value)
    {
        _name = name;
        _value = value;
    }

    // Override method to display the status of a goal
    public override void DisplayStatus() // Overrides the DisplayStatus method from the base class Goal
    {
        Console.WriteLine($"Goal: {_name} [{(IsComplete ? 'X' : ' ')}]"); // Display the goal name and whether it is complete or not
    }

    public override void RecordEvent() // Overrides the RecordEvent method from the base class Goal
    {
        if (!IsComplete) // Check if the goal is not already complete
        {
            IsComplete = true; // Mark the goal as complete
            Console.WriteLine($"Event recorded: Completed {_name}! +{_value} points"); // Display message indicating the goal is completed and points earned
        }
        else
        {
            Console.WriteLine($"{_name} is already completed."); // Display message is goal is completed
        }
    }

    private bool IsComplete { get; set; } = false; // Private Property go check if goal is complete or not and to control access to the IsComplete field
}