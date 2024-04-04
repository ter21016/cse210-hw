using System;
using System.Diagnostics;


public class ChecklistGoal : Goal
{
    private int AmountCompleted;
    private int Target;
    private int Bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        AmountCompleted = 0;
        Target = target;
        Bonus = bonus;
    }

    public override int RecordEvent()
    {
        AmountCompleted++;
        if (IsComplete())
            return Target + Bonus;
        else
            return Target;
    }

    public override bool IsComplete()
    {
        return AmountCompleted >= Target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortname}: {_description}\nPoints: {_points}\nTarget: {Target}\nBonus: {Bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"checklist:{_shortname}:{_description}:{_points}:{Target}:{Bonus}:{AmountCompleted}";
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
