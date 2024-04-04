using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!\n");
        return Convert.ToInt32(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortname}: {_description}\nPoints: {_points}\nThis goal is eternal.";
    }

    public override string GetStringRepresentation()
    {
        return $"eternal:{_shortname}:{_description}:{_points}";
    }
}
