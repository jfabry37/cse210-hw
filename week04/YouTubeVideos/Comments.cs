using System.Globalization;

public class Comments
{
    private string _commenter;
    private string _comment;
    
    public Comments(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }
 
    public string GetDisplayText()
    {
        // Iterate through the list to be Displayed in the main program
      return $"Name: {_commenter} ({_comment})";  
    }
}