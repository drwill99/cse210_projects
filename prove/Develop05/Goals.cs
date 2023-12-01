using System;

public abstract class Goals
{

    protected string _title;
    protected string _description;
    protected int _points;

    protected List<string> _listOfGoals = new List<string>();

    public Goals(string goalName, string goalDescription, int pointsEarned)
    {
        _title = goalName;
        _description = goalDescription;
        _points = pointsEarned;
    }


    public string GetName()
    {
        return _title;
    }

    public void SetName(string goalName)
    {
        _title = goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string goalDescription)
    {
        _description = goalDescription;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int pointsEarned)
    {
        _points = pointsEarned;
    }

    public virtual string GetInformation()
    {
        return $"[] {_title} ({_description})";
    }

    public virtual int GetCompleted(int userPoints)
    {
        return userPoints;
    }

    public virtual string GetRepresentation()
    {
        return "Goal:" + _title + "," + _description + "," + _points + "," + false;
    }


}