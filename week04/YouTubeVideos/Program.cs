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
        video1.AddComment ("Joe", "Amazing.");
        video1.AddComment ("Lloyd","Great video."); 

        Video video2 = new Video ("Learn Python", "Jane", "3:45");
        video2.AddComment ("Alice", "Loved it!");
        video2.AddComment ("Bob", "Well explained.");
        video2.AddComment ("John","Superb content.");

        Video video3 = new Video ("Python Functions", "Tom", "4:15");
        video3.AddComment ("Eve", "Very informative.");
        video3.AddComment ("Sam", "Very Helpful."); 
        video3.AddComment ("James","Amazing content.");    

        videos.Add (video1);
        videos.Add (video2);
        videos.Add (video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }

}