using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        var wordsToHide = random.Next(1, Math.Min(numberToHide + 1, visibleWords.Count + 1));

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        var displayText = "";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()}: {displayText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    

}