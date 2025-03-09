// Entry.cs
class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Goal { get; set; }


    

    public Entry(string date, string prompt, string response, string goal)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Goal = goal;
        


    }

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nGoal for Tomorrow: {Goal}\n");
    }
}