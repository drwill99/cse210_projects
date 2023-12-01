using System;

public class EternalGoals : Goals
{

    public EternalGoals(string goalName, string goalDescription, int pointsEarned) : base(goalName, goalDescription, pointsEarned)
    {
        _title = goalName;
        _description = goalDescription;
        _points = pointsEarned;
    }

    public override string GetInformation()
    {
        return $"[] {_title} ({_description})";
    }


    public override int GetCompleted(int userPoints)
    {
        GetInformation();
        userPoints = userPoints + _points;
        return userPoints;
    }

    public override string GetRepresentation()
    {
        return "EternalGoals:" + _title + "," + _description + "," + _points;
    }
}