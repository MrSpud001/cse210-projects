class Scripture
{
    private Reference _ref;
    private List<Word> _words = [];

    public Scripture(Reference reference, string text)
    {
        _ref = reference;


        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hidden_words = 0;
        Random random = new Random();

        while (hidden_words < numberToHide)
        {

            int index = random.Next(0, _words.Count);
            

            // if chosen word is already hidden, choose different word
            while (_words[index].IsHidden())
            {
                index = random.Next(0, _words.Count);
            }


            _words[index].Hide();

            hidden_words += 1;

            if (IsCompletelyHidden())
            {
                return;
            }
            
        

        }

    }

    public string GetDisplayText()
    {
        string str = "";

        foreach (Word word in _words)
        {
            str += word.GetDisplayText();
            str += " ";
        }


        return $"{_ref.GetDisplayText()} {str}";
    }

    public bool IsCompletelyHidden()
    {

        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
                
            }
        }


        return true;
    }

}