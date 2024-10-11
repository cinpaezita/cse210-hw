using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of videos    
        List<Video> videos = new List<Video>();

        //Create videos and add comments
        Video video1 = new Video("Learn about Abstraction in C#", "Cinthia", 1020);
        video1.AddComment(new Comment("Jenna", "Great tutorial!"));
        video1.AddComment(new Comment("Marcus", "Very hepful!!!"));
        video1.AddComment(new Comment("Paula", "Love the examples!"));
        videos.Add(video1);

        Video video2 = new Video("Introduction to Encapsulation", "Cinthia", 2700);
        video2.AddComment(new Comment("Amin", "Thanks for the resources, this helped me understand better"));
        video2.AddComment(new Comment("Lorie", "Very informative :)"));
        video2.AddComment(new Comment("Jack", "Great examples! It made the concept much easier to grasp"));
        videos.Add(video2);

        Video video3 = new Video("Mastering Abstraction", "Cinthia", 1800);
        video3.AddComment(new Comment("Carlos", "I appreciate the clear explanations"));
        video3.AddComment(new Comment("Emily", "This was exactly what I needed, great video!"));
        video3.AddComment(new Comment("James", "Could you also cover abstractions in interfaces in more detail?"));
        video3.AddComment(new Comment("Tammy", "The examples on abstraction really made things clearer for me"));
        videos.Add(video3);

        //Display
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comnents:");

            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(); //Ad a blanck line between videos
        }


    }
}