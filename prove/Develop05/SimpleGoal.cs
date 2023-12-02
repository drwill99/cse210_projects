public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value)
    {
        _name = name;
        _value = value;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"Goal: {_name} [{(IsComplete ? 'X' : ' ')}]");
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Event recorded: Completed {_name}! +{_value} points");
        }
        else
        {
            Console.WriteLine($"{_name} is already completed.");
        }
    }

    private bool IsComplete { get; set; } = false;
}