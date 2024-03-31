public class SimpleGoal : Goal
{

    SimpleGoal myGoal = new SimpleGoal("Study the Scriptures", 100);

    public SimpleGoal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public override void RecordEvent()
    {
        // Here you can implement the logic to record event for simple goals
    }

    public override bool IsComplete()
    {
        // Here you can implement the logic to check if simple goal is complete
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Here you can implement the logic to get string representation of simple goal
        return $"Simple Goal: {name}";
    }
}