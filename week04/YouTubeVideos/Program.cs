using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold videos
            List<Video> videos = new List<Video>();

            // Create video 1 (from Mosh's C# tutorial series)
            Video video1 = new Video("C# Tutorial for Beginners: Learn C# from Scratch", "Programming with Mosh", 1800);
            video1.AddComment("JohnDoe", "Great introduction to C#!");
            video1.AddComment("AliceSmith", "Very clear explanations.");
            video1.AddComment("BobJohnson", "When will part 2 be available?");
            videos.Add(video1);

            // Create video 2
            Video video2 = new Video("C# OOP: Classes and Objects", "Programming with Mosh", 2400);
            video2.AddComment("SarahWilliams", "Finally understand classes!");
            video2.AddComment("MikeBrown", "Could you do more examples with inheritance?");
            video2.AddComment("EmilyDavis", "Perfect timing for my university project.");
            videos.Add(video2);

            // Create video 3
            Video video3 = new Video("C# Collections: Lists, Arrays, and Dictionaries", "Programming with Mosh", 1500);
            video3.AddComment("DavidWilson", "Collections finally make sense.");
            video3.AddComment("LisaTaylor", "The dictionary example was especially helpful.");
            video3.AddComment("TomMoore", "Would love to see more advanced collection topics.");
            videos.Add(video3);

            // Display all videos and their comments
            Console.WriteLine("YouTube Video Analysis Program\n");
            foreach (var video in videos)
            {
                video.DisplayVideoInfo();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}