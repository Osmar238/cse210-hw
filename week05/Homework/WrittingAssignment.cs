using System;

class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string Title { get => _title; set => _title = value; }

    public string GetWrittingInformation()
    {
        string studentName = StudentName;
         return $"{_title} by {studentName}";
    }
}