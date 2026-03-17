using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engeenier";
        Job1._company = "Apple";
        Job1._startYear = 2003;
        Job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(Job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}