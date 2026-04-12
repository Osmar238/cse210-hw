using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string ShortName { get => _shortName; set => _shortName = value; }
    public string Description { get => _description; set => _description = value; }

    protected Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        Description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        
        if (IsComplete())
        {
            return $"[X] {ShortName} ({Description})";
        }
        else
        {
            return $"[ ] {ShortName} ({Description})";
        }
    }

    public abstract string GetStringRepresentation();

    public string GetShortName()
    {
        return ShortName;
    }

    public string GetDescription()
    {
        return Description;
    }

    public int GetPoints()
    {
        return _points;
    }

    
    


}