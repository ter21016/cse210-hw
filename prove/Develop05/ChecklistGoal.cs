public class ChecklistGoal : Goal
{
    private int completedTimes;
    private int requiredTimes;

    public ChecklistGoal(string name, int points, int requiredTimes)
    {
        this.name = name;
        this.points = points;
        this.requiredTimes = requiredTimes;
    }

    public override void RecordEvent()
    {
        // Here you can implement the logic to record event for checklist goals
        completedTimes++;
    }

    public override bool IsComplete()
    {
        return completedTimes >= requiredTimes;
    }

    public override string GetStringRepresentation()
    {
        // Here you can implement the logic to get string representation of checklist goal
        return $"Checklist Goal: {name}, Completed {completedTimes}/{requiredTimes} times";
    }
}