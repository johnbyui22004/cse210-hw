// John Earl
public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = startVerse;
        this.endVerse = endVerse; 
    }

    public string GetFormattedReference()
    {
        if (verse == endVerse)
            return $"{book} {chapter}:{verse}";
        else
            return $"{book} {chapter}:{verse}-{endVerse}";
    }
}
