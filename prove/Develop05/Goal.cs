public abstract class Goal 
{
    protected string _name = "";

    public string Name
    {
        get { return _name ?? ""; }
        set { _name = value ?? ""; }
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