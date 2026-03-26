
class SimpleGoal : Goal
{
    public SimpleGoal(): base()
    {
        
    }

    public override void CreateGoal()
    {
        base.SetName();
        base.SetDescription();
        base.SetPoints();
        base.SetGoalType("Simple");
    }
}