using System;

class Assignment
{
    private string _studentName;
    private string _topic;

    public string Topic { get => _topic; set => _topic = value; }
    public string StudentName { get => _studentName; set => _studentName = value; }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    
}