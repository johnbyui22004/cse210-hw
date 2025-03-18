using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        string[] wordArray = text.Split(' ');  
        
        // Create Word objects for each word in the text
        foreach (var word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        int index = rand.Next(words.Count);
        words[index].Hide();
    }

    public string GetFormattedScripture()
    {
        List<string> renderedText = new List<string>();
        foreach (var word in words)
        {
            renderedText.Add(word.GetRenderedText());
        }
        return $"{reference.GetFormattedReference()}\n" + string.Join(" ", renderedText);
    }
}
