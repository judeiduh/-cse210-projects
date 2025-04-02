public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return $"{_book} {_chapter}:{_startVerse}";
    }

    public static Reference Parse(string referenceText)
    {
        var parts = referenceText.Split(' ');
        var chapterVersePart = parts.Last();
        var book = string.Join(" ", parts.Take(parts.Length - 1));
        
        var cvParts = chapterVersePart.Split(':');
        var chapter = int.Parse(cvParts[0]);
        var verses = cvParts[1].Split('-');
        
        if (verses.Length == 1)
            return new Reference(book, chapter, int.Parse(verses[0]));
        
        return new Reference(book, chapter, 
            int.Parse(verses[0]), int.Parse(verses[1]));
    }
}