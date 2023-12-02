// Base class for goals

public abstract class Goal 
{
    protected string _name = ""; // Intialize to empty string to avoid null reference

    public string Name
    {
        get { return _name ?? ""; } // Return empty string if _name is null
        set { _name = value ?? ""; } // Assign empty string if value is null
    }

    protected int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public abstract void DisplayStatus();
    public abstract void RecordEvent();
}