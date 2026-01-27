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


    public void ListOfComments()
    {
     //create a list of comments with the commenter's name.
     
     //Also count the number of comments there are to pass to 
     // video class to be displayed.
        List<commentEntry> comments = new List<commentEntry>();
        comments.Add(new commentEntry(_commenter, _comment));
    } 
    public int NumberofCommnets()
    {
        foreach ( commentEntry C in Comments);
        {
            count++;
        }
        return count;
    }
    public string GetDisplayText()
    {
        // Iterate through the list to be Displayed in the main program

        foreach ( commentEntry C in Comments);
        {
         return$"Name{_commenter}: {_comment}";   
        }
        
    }

}