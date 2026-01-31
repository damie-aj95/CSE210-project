using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Zainab", "Great explanation!"));
        video1.AddComment(new Comment("Yinka", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Loved this video."));
        videos.Add(video1);

        Video video2 = new Video("Understanding OOP", "TechFamily", 900);
        video2.AddComment(new Comment("Dora", "This finally makes sense."));
        video2.AddComment(new Comment("Hakeem", "Clear and concise."));
        video2.AddComment(new Comment("Faith", "Thanks for this!"));
        videos.Add(video2);

        Video video3 = new Video("Abstraction Explained", "DamiWorld", 750);
        video3.AddComment(new Comment("Felix", "Excellent examples."));
        video3.AddComment(new Comment("Hannah", "Well done."));
        video3.AddComment(new Comment("Ola", "Very informative."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
