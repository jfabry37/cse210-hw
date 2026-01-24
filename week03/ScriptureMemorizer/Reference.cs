using System.Security.Cryptography;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference( string book, int Chapter, int verse )
    {
        _book = book;
        _chapter = Chapter;
        _verse = verse;
    }

    public Reference(string book, int Chapter, int vers, int endVerse)
    {
        _book = book;
        _chapter = Chapter;
        _verse = vers;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
    
        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}