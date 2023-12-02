public class EternalGoal : Goal
{
    public EternalGoal(string name, int value)
    {
        _name = name;
        _value = value;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"Eternal Goal: {_name} (Value: {_value})");
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded: {_name}! +{_value} points");
    }

    
}