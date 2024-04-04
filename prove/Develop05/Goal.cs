using System;

public abstract class Goal
{
    protected string _shortname;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

    public static Goal CreateGoal(string[] data)
    {
        string type = data[0];
        string name = data[1];
        string description = data[2];
        string points = data[3];

        switch (type)
        {
            case "simple":
                return new SimpleGoal(name, description, points);
            case "eternal":
                return new EternalGoal(name, description, points);
            case "checklist":
                int target = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);
                int amountCompleted = int.Parse(data[6]);
                return new ChecklistGoal(name, description, points, target, bonus);
            default:
                throw new ArgumentException("Invalid goal type.");
        }
    }
}
