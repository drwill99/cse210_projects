// ChecklistGoal class for goals with a checklist
public class ChecklistGoal : Goal // ChecklistGoal inherits from base class Goal
{
    private int _targetCount; // Private field to store target count for checklist
    private int _completedCount; // Private field to store completed count for checklist

    // Constructor to initialize ChecklistGoal with name, value and target count
    public ChecklistGoal(string name, int value, int targetCount)
    {
        _name = name;
        _value = value;
        _targetCount = targetCount;
    }

    // Override method to display status of checklist goal
    public override void DisplayStatus() // Overrides DisplayStatus method from base class Goal
    {
        // Display checklist goal name, completed count, and target count
        Console.WriteLine($"Checklist Goal: {_name} [{_completedCount}/{_targetCount}]");
    }

    // Override method to record event for checklist goal
    public override void RecordEvent() // Overrides RecordEvent method from base class Goal
    {
        // Check if completed count is less than target count
        if (_completedCount < _targetCount)
        {
            _completedCount++; // Increment completed count
            Console.WriteLine($"Event recorded: Completed {_name} ({_completedCount}/{_targetCount})! +{_value} points");

            // Check if completed count has reached target count
            if (_completedCount == _targetCount)
            {
                // Display bonus message and update value with bonus points
                Console.WriteLine($"Bonus! Goal {_name} completed {_targetCount} times. +{_value * 5} bonus points!");
                _value += _value * 5;
            }
        }
        else
        {
            // Display message if checklist goal is already completed
            Console.WriteLine($"{_name} is already completed.");
        }
    }
}