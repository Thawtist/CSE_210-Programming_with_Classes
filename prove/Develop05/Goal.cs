

abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;


    public Goal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }


    public void SetName()
    {
        Console.Write("Pleas enter the name of your goal: ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("Please enter a description of your goal: ");
        _description = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.Write("Please enter the number of points associated with this goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public void SetGoalType(string GoalType)
    {
        _goalType = GoalType;
    }

    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_name}, {_description}, {_numberOfPoints}, {_status}, {_goalType}";
    }

    public abstract void CreateGoal();
}