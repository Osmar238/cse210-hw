using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity3 = new ListingActivity();
                activity3.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to try again.");
                Console.ReadLine();
            }
        }
    }
}