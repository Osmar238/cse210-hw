using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        
        Video v1 = new Video("Learn C# in 10 minutes", "CodeMaster", 600);
        v1.AddComment(new Comment("John", "Excellent explanation!"));
        v1.AddComment(new Comment("Mary", "Helped me a lot with my homework."));
        v1.AddComment(new Comment("Charles", "Could you make one about lists?"));
        videos.Add(v1);

        
        Video v2 = new Video("Best Laptops 2026", "TechReview", 1200);
        v2.AddComment(new Comment("Anna", "I have the second one and it's great."));
        v2.AddComment(new Comment("Louis", "Too expensive for what it offers."));
        v2.AddComment(new Comment("Peter", "Good video, I subscribe."));
        videos.Add(v2);

        
        Video v3 = new Video("Homemade Pizza Recipe", "ChefAtHome", 850);
        v3.AddComment(new Comment("Sophia", "Looks delicious!"));
        v3.AddComment(new Comment("James", "I tried to make it and burned it haha."));
        v3.AddComment(new Comment("Laura", "Thanks for the recipe."));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()} | Author: {v.GetAuthor()} | Length: {v.GetLength()}s");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.GetName()}: {c.GetText()}");
            }
            Console.WriteLine();
        }
    }
}