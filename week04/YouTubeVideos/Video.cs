using System;
using System.Collections.Generic;

namespace YouTubeVideoProgram
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
        }

        public void AddComment(string commenterName, string commentText)
        {
            _comments.Add(new Comment(commenterName, commentText));
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Video: \"{Title}\" by {Author} ({LengthInSeconds} seconds)");
            Console.WriteLine($"Comments ({GetNumberOfComments()}):");
            
            foreach (var comment in _comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: \"{comment.CommentText}\"");
            }
            
            Console.WriteLine();
        }
    }
}