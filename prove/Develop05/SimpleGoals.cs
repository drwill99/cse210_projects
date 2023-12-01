using System;

public class SimpleGoals : Goals
{

    private bool _checked = false;
    private bool _completed = false;


    public SimpleGoals(string goalName, string goalDescription, int pointsEarned, bool checkedGoal = false) : base(goalName, goalDescription, pointsEarned)
    {
        _title = goalName;
        _description = goalDescription;
        _points = pointsEarned;
        _checked = checkedGoal;
    }


    public override string GetInformation()
    {
        {
            if (_checked){
                _completed = true;
                return "[X] " + _title + " (" + _description + ")";}
            else{
                return "[ ] " + _title + " (" + _description + ")";}
        }
    }


    public override int GetCompleted(int userPoints)
    {
        
        bool completed = _completed;

        _checked = true;
        if (completed == false)
        {
            GetInformation();
            
            userPoints = userPoints + _points;
            completed = true;
            return userPoints;
        }
        else
        {
            
            GetInformation();
            return userPoints;
        }
        
    }
    

    public override string GetRepresentation()
    {
        return "SimpleGoal:" + _title + "," + _description + "," + _points + "," + _checked;
    }


}