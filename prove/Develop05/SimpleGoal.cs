using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!\n");
        return Convert.ToInt32(_points);
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return $"{_shortname}: {_description}\nPoints: {_points}\nThis goal is simple.";
    }

    public override string GetStringRepresentation()
    {
        return $"simple:{_shortname}:{_description}:{_points}";
    }
}

