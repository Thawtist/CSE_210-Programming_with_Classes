using System;
using System.Collections.Generic;

class Program
{
        /// <summary>
        /// Main program for testing Video and Comment classes.
        /// </summary>
        /// <remarks>
        /// Creates a list of Video objects and adds comments to each one.
        /// Displays the title, author, length, and comments of each video.
        /// </remarks>
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("C# Basics", "Jane", 600);
        v1.AddComment(new Comment("Alice", "first"));
        v1.AddComment(new Comment("Bob", "Great video!"));
        v1.AddComment(new Comment("Charlie", "Very helpful"));
        v1.AddComment(new Comment("Dana", "Thanks!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("OOP Concepts", "John", 800);
        v2.AddComment(new Comment("Eve", "Nice explanation"));
        v2.AddComment(new Comment("Alice", "second"));
        v2.AddComment(new Comment("Frank", "Loved it"));
        v2.AddComment(new Comment("Grace", "Clear and simple"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Abstraction in C#", "Mike", 700);
        v3.AddComment(new Comment("Alice", "first"));
        v3.AddComment(new Comment("Hank", "Now I get it"));
        v3.AddComment(new Comment("Ivy", "Awesome"));
        v3.AddComment(new Comment("Jake", "Good examples"));
        videos.Add(v3);

        // Video 4
        Video v4 = new Video("C# Generics", "Jane", 600);
        v4.AddComment(new Comment("Alice", "first"));
        v4.AddComment(new Comment("Bill", "I liked it!"));
        v4.AddComment(new Comment("George", "Nicely done!"));
        videos.Add(v4);

        // Display
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}