// Entry.cs
class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        


    }

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n");
    }
}