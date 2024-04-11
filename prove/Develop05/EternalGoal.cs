public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional attributes needed for EternalGoal
    }

    public override void RecordEvent()
    {
        // No specific event to record for EternalGoal
    }

    public override bool IsComplete()
    {
        return false; // EternalGoal is never complete
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}; {_description}; {_points}";
    }
}



