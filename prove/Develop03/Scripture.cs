public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        foreach (string word in text.Split(" "))
        {
            Word thisWord = new Word(word);
            _words.Add(thisWord);
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        int i = 0;
        int timesHidden = 0;
        Random word = new Random();
        int notHidden = _words.Count - CountHiddenWords();

        while (timesHidden < Math.Min(numberToHide, notHidden))
        {            
            i = word.Next(_words.Count);

            if(_words[i].IsHidden())
            {
                continue;
            }
            else
            {
                _words[i].Hide();
                timesHidden++;
            }
        }
    }

    private int CountHiddenWords()
    {
        int hiddenWordCount = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWordCount++;
            }
            else
            {
                continue;
            }
        }

        return hiddenWordCount;
    }

    public string GetDisplayText()
    {
        string word = "";
        
        foreach(Word thisWord in _words)
        {
            word += $"{thisWord.GetDisplayText()} ";
        }

        return $"{_reference.GetDisplayText()} \n\n{word}";
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(word.IsHidden())
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}