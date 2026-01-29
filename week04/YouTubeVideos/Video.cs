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

        string [] parts = _length.Split(':');
        string minutes = parts[0];
        string seconds = parts[1];
        _length = (int.Parse(minutes) * 60 + int.Parse(seconds)).ToString(); 
        
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comments (name, text));
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}  By: {_author}  Length: {_length} seconds  Number of Comments: {_comments.Count}.");
        foreach (Comments comment in _comments)
        {
            comment.GetDisplayComment();
        }
    }
}