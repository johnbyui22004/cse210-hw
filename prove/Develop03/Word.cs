public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;  // Words are visible initially
    }

    public string GetText() => text;

    public bool IsHidden() => isHidden;

    public void Hide() => isHidden = true;

    public void Show() => isHidden = false;

    public string GetRenderedText() => isHidden ? "____" : text;
}
