
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (!visibleWords.Any()) return;

        var random = new Random();
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
        }
    }

    public bool AllWordsHidden() => _words.All(w => w.IsHidden());
    
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n\n" +
               string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}