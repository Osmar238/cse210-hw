using System;

public class Entry
{
    public string _date;
    public string _questionPrompt;
    public string _userText;

    public void Display()
    {
        
        Console.WriteLine($"Date: {_date} Question: {_questionPrompt}");
        Console.WriteLine($"{_userText}");
    }

}