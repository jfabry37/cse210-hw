//using System.Diagnostics;
public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comments> _comments;
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comments (name, text));
    }
    public void VideoLength()
    {
        // length of the of the video.
        // string [] parts = _length.Split(':');
        // string minutes = [0];
        // string seconds = [1];
        //Length= (minutes * 60) + seconds;   
    }
    public void Display()
    {
        //Display the Title, Author, Length, and # of comments 
        // To display in the main program.
        Console.WriteLine($"title:{_title} By:{_author} Length:{_length}, with #{_comments.Count} comments.");
        foreach (Comments comment in _comments)
        {
            comment.GetDisplayComment();
        }
    }

}