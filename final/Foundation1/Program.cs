using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Understanding C#", "Tech Tutorials", 600);
        video1.AddComment(new Comment("John Doe", "Greatness!"));
        video1.AddComment(new Comment("Jane Smith", "Thanks, this was helpful."));
        video1.AddComment(new Comment("Alice Johnson", "First comment"));

        Video video2 = new Video("Intro to Python", "Learning Hub", 300);
        video2.AddComment(new Comment("Alice Johnson", " informative!"));
        video2.AddComment(new Comment("Bob Lee", "Nice"));
        video2.AddComment(new Comment("Charlie Kim", "so good"));

        Video video3 = new Video("10 subscribers", "Tech Tutorials", 500);
        video3.AddComment(new Comment("John Doe", "Great"));
        video3.AddComment(new Comment("Jane Smith", "Thanks"));
        video3.AddComment(new Comment("Karen Moe", "we want more "));

        Video video4 = new Video("100 subscribers!", "Learning Hub", 400);
        video4.AddComment(new Comment("Alice Johnson", "congrats"));
        video4.AddComment(new Comment("Bob Lee", "good job"));
        video4.AddComment(new Comment("Dave Coop", "yay"));

        Video[] videos = { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Video: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
