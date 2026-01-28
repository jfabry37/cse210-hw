using System;
using System.Diagnostics;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video ("C# classes", "Bob", "2:30");
        video1.AddComment ("Mary", "Very helpful.");
        video1.AddComment ("Joe", "This is amazing.");
        video1.AddComment ("Lloyd","Great video."); 
       
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        videos.Add (video1);
        //Video newVideo = new Video (title, author, length);
        //Comments newComments = new Comments (name, comment);
    }

}