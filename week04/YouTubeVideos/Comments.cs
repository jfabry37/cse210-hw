public class Comments
{
    private string _commenter;
    private string _comment;
    
    public Comments(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }
    public void GetDisplayComment()
    {
      Console.WriteLine($"Name: {_commenter} ({_comment})");  
    }
}