public class Video
{
    private string _title;
    private string _author;
    private string _length;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void VideoLength()
    {
        // length of the of the video.
        string [] parts = length.Split(':');
        minutes = int.TryParse[0];
        seconds = int.TryParse[1];
        Length= (minutes * 60) + seconds;   
    }

    public void NumberOfComments(int number)
    {
        // retrieves the number of comments from newcomments.ListOfComments
        number = newComments.NumberofCommnets(number);
    }
    public string GetDisplayText()
    {
        //Display the Title, Author, Length, and # of comments 
        // To display in the main program.
        return $"title:{_title} By:{_author} Length:{_length}, with #{number} comments.";
    }



}