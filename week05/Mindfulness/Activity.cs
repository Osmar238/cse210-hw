using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity
{

    private string _name;
    private string _description;

    private int _duration;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public int Duration { get => _duration; set => _duration = value; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {Name}");
        Console.WriteLine();
        Console.WriteLine($"{Description}");
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {Duration} seconds of the {Name}.");
        ShowSpinner(5); 
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); 
            Console.Write("\b \b"); 

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0; 
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }
}