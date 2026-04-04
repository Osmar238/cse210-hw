using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine(); 
            Console.Write("Breathe in...");
            ShowCountDown(4); 
            Console.WriteLine();
            
            Console.Write("Breathe out...");
            ShowCountDown(6); 
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}