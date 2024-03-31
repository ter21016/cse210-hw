using System;

public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool completed;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.completed = false;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}
