class EternalGoal: Goal
{

    public EternalGoal( string name, string description, string points): base(name, description, points)
    {
        // nothing is to be done; this goal is never completed
    }    

    public override void RecordEvent()
    {
        // nothing is to be done; this goal is never completed
    }

    public override bool IsComplete()
    {
        return false;
    } 

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }

}
