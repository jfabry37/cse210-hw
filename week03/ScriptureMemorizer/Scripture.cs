using System.Diagnostics;

public class Scripture
{
    private Reference _reference;
    private List<Word>  _words;

    public Scripture (Reference reference, string text)
    {
        // list the text string to an object list
        _reference = reference;
        _words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word=> new Word(word)).ToList();


    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenNumber = 0;
        int availableToHide = _words.Count(w=> !w.isHidden()); 
        numberToHide = Math.Min(numberToHide, availableToHide);
        while (hiddenNumber < numberToHide && availableToHide >= numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenNumber++;
            }
            //availableToHide - 1 = availableToHide;
        }
    }
    
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $" {_reference.GetDisplayText()}: {wordsText}";
       
    }

    public bool IsCompletelyHidden()
    {
        bool complete = false;
        int available = _words.Count(w=> !w.isHidden());
        if (available == 0)
        {
            complete= true;
        }

        return complete;
    }
}