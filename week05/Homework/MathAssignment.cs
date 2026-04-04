using System;

class MathAssigment : Assignment
{
    private string _textbookSection;
    private string _problems;


    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        TextbookSction = textbookSection;
        Problems = problems;
    }

    public string TextbookSction { get => _textbookSection; set => _textbookSection = value; }
    public string Problems { get => _problems; set => _problems = value; }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

    
}