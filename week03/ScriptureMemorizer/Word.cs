public class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;  
    }
    public void Show ()
    {
        _isHidden = false;
    }
    public bool isHidden()
    {
            return _isHidden;  
    }
    public string GetDisplayText()
    {
        return  _isHidden ? new string('_', _word.Length): _word;
    }

}