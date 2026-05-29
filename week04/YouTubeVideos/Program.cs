using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("title1", "author1", 52, [new Comment("commentor1","comment1"),new Comment("commentor2","comment2") ,new Comment("commentor3","comment3")]);
        Video video2 = new Video("title2", "author2", 106, [new Comment("commentor1","comment1"),new Comment("commentor2","comment2") ,new Comment("commentor3","comment3")]);
        Video video3 = new Video("title3", "author3", 807, [new Comment("commentor1","comment1"),new Comment("commentor2","comment2") ,new Comment("commentor3","comment3")]);
        Video video4 = new Video("title4", "author4", 32, [new Comment("commentor1","comment1"),new Comment("commentor2","comment2") ,new Comment("commentor3","comment3")]);

        List<Video> videos = [video1, video2, video3, video4];

        foreach(Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}