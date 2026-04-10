using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine("This goal has been register");
    }


    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

}