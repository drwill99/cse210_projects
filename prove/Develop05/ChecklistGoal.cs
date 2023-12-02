public class ChecklistGoal : Goal 
{
    private int _targetCount; 
    private int _completedCount; 

    
    public ChecklistGoal(string name, int value, int targetCount)
    {
        _name = name;
        _value = value;
        _targetCount = targetCount;
    }

    public override void DisplayStatus() 
    {
       
        Console.WriteLine($"Checklist Goal: {_name} [{_completedCount}/{_targetCount}]");
    }

    public override void RecordEvent()
    {
       
        if (_completedCount < _targetCount)
        {
            _completedCount++; 
            Console.WriteLine($"Event recorded: Completed {_name} ({_completedCount}/{_targetCount})! +{_value} points");

           
            if (_completedCount == _targetCount)
            {
                Console.WriteLine($"Bonus! Goal {_name} completed {_targetCount} times. +{_value * 5} bonus points!");
                _value += _value * 5;
            }
        }
        
        else
        {
            Console.WriteLine($"{_name} is already completed.");
        }


    }


}