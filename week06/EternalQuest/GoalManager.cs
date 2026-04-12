using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int option = 0;

        while (option != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine(@"
            Menu Option:
            1.  Create New Goal
            2.  List Goals
            3.  Save Goals
            4.  Load Goals
            5.  Record Event
            6.  Quit");

            Console.WriteLine("Select a choice from the menu");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoalDetails();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;
                
                case 5:
                    RecordEvent();
                    break;
                
                case 6:
                    Console.WriteLine("Goodbye");
                    break;
            }
        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    
    public void ListGoalNames()
    {
        int count = 1;
        
        foreach (Goal meta in _goals)
        {
            string nombreDeLaMeta = meta.GetShortName();
            Console.WriteLine($"{count}. {nombreDeLaMeta}");
            count++; 
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int count = 1;

        foreach (Goal meta in _goals)
        {
            Console.WriteLine($"{count}. {meta.GetDetailsString()}");
            count++; 
        }

        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine(@"
        What is the new Goal that you want to create?
        
        Choose from this options:

        1. Simple
        2. Eternal
        3.Checklist
        ");

        int answer = int.Parse(Console.ReadLine());

        Console.WriteLine(@"
        Answer this quesitions about your new goal:
        
        What is gone to be the name of your goal?
        ");

        string namegoal = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("What is your description");

        string description = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("How many points it equals");

        int points = int.Parse(Console.ReadLine());

        Console.Clear();

        
        if (answer == 1)
        {
            SimpleGoal newSimple = new SimpleGoal(namegoal, description, points);
            _goals.Add(newSimple);
        }
        else if (answer == 2)
        {
            EternalGoal newEternal = new EternalGoal(namegoal, description, points);
            _goals.Add(newEternal);
        }
        else if (answer == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal newChecklist = new ChecklistGoal(namegoal, description, points, target, bonus);
            _goals.Add(newChecklist);
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames(); 
        
        Console.Write("Enter goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1; 

        int pointsEarned = _goals[goalIndex].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");
        
        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? (e.g. goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("\nGoals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            // Leemos todas las líneas del archivo de golpe
            string[] lines = File.ReadAllLines(filename);
            
            // La primera línea siempre es tu puntaje
            _score = int.Parse(lines[0]);
            
            // Limpiamos la lista actual para no duplicar si cargas dos veces
            _goals.Clear(); 

            // Empezamos desde la línea 1 (ignorando la 0 que era el puntaje)
            for (int i = 1; i < lines.Length; i++)
            {
                // Separamos el tipo de meta de sus detalles
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] details = parts[1].Split(',');

                // Reconstruimos la meta dependiendo de su tipo
                if (goalType == "SimpleGoal")
                {
                    SimpleGoal newSimple = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                    // Si el archivo dice que ya estaba completa (True), registramos el evento en secreto
                    if (bool.Parse(details[3])) 
                    { 
                        newSimple.RecordEvent(); 
                    }
                    _goals.Add(newSimple);
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal newEternal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                    _goals.Add(newEternal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    // Nota: En GetStringRepresentation pusimos bonus antes que target
                    ChecklistGoal newChecklist = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[3]));
                
                    int amountCompleted = int.Parse(details[5]);
                    for (int j = 0; j < amountCompleted; j++) 
                    { 
                        newChecklist.RecordEvent(); 
                    }
                    _goals.Add(newChecklist);
                }
            }
            Console.WriteLine("\nGoals loaded successfully!");
        }
        else
        {
            Console.WriteLine("\nFile not found. Please check the name and try again.");
        }
    }
}