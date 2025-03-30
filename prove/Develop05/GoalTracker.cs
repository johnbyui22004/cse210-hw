class GoalTracker
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private string saveFile = "goals.txt";

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            score += goals[index].RecordEvent();
        }
    }

    public void ShowGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {score}\n");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(saveFile))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.SaveData());
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists(saveFile))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(saveFile);
            score = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                Goal goal = parts[0] switch
                {
                    "SimpleGoal" => new SimpleGoal(parts[1], int.Parse(parts[2])),
                    "EternalGoal" => new EternalGoal(parts[1], int.Parse(parts[2])),
                    "ChecklistGoal" => new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])),
                    _ => null
                };
                
                if (goal != null)
                {
                    goal.LoadData(parts);
                    goals.Add(goal);
                }
            }
        }
    }
}