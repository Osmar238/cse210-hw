using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");

        Console.Write("My name is: ");
        string name = Console.ReadLine();

        Console.WriteLine("Wow!, and what is your last name?");

        Console.Write("My last name is: ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Ok, so, you are {name} {last_name}");
        Console.WriteLine("That´s right =)");
    }
}