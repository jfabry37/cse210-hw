class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted): base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override bool IsComplete()
    {   
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        } 
        
    }


    public override string GetDetailsString()
    {
        return $" -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_amountCompleted},{_target}";
    }



}