public class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public override void RecordEvent()
    {
        // Here you can implement the logic to record event for eternal goals
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Here you can implement the logic to get string representation of eternal goal
        return $"Eternal Goal: {name}";
    }
}