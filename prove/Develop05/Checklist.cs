using System;

public class ChecklistGoal : Goals
{
    private int _presentCounter;
    private int _checkCounter;
    private int _bonusCompleted;
    private bool _checked = false;




    public ChecklistGoal(string goalName, string goalDescription, int pointsEarned, int checkCounter, int bonusCompleted, int presentCounter = 0, bool Goalchecked = false) : base(goalName, goalDescription, pointsEarned)
    {
        
        _title = goalName;
        _description = goalDescription;
        _points = pointsEarned;
        _checkCounter = checkCounter;
        _bonusCompleted = bonusCompleted;
        _presentCounter = presentCounter;
        _checked = Goalchecked;
    }



    public int GetCheckCounter()
    {
        return _checkCounter;
    }
    public void SetCheckCounter(int checkCounterToSet)
    {
        _checkCounter = checkCounterToSet;
    }
    public int GetBonusCompleted()
    {
        return _bonusCompleted;
    }
    public void SetBonusCompleted(int BonusCompletedToSet)
    {
        _bonusCompleted = BonusCompletedToSet;
    }
    public int GetPresentCounter()
    {
        return _presentCounter;
    }
    public void SetPresentCounter(int PresentCounterToSet)
    {
        _presentCounter = PresentCounterToSet;
    }



    public override string GetInformation()
    {
        if (_checked)
        {
            return $"[X] {_title} ({_description}) -- Currently completed {GetPresentCounter()}/{_checkCounter}";
        }
        else
        {
            return $"[ ] {_title} ({_description}) -- Currently completed {GetPresentCounter()}/{_checkCounter}";
        }
    }

    public override int GetCompleted(int userPoints)
    {
        _presentCounter = _presentCounter + 1;
        int presentCounter = _presentCounter;
        SetPresentCounter(presentCounter);

        string goalInformation = GetInformation();

        int index = _listOfGoals.IndexOf(goalInformation);
        string newGoalInformation;


        if (_presentCounter == _checkCounter)
        {
            _checked = true;
            newGoalInformation = GetInformation();


            userPoints = userPoints + _bonusCompleted;

            userPoints = userPoints + _points;
        }
        else if (_presentCounter > _checkCounter)
        {
            _presentCounter = _presentCounter - 1;
        }
        else
        {
            newGoalInformation = goalInformation;

            userPoints = userPoints + _points;
        }

        return userPoints;
    }


    public override string GetRepresentation()
    {
        return "ChecklistGoal:" + _title + "," + _description + "," + _points + "," + _checkCounter + "," + _bonusCompleted + "," + _presentCounter;
    }


}