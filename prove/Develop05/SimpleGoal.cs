class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => IsCompleted ? "[X] " + Name : "[ ] " + Name;
    public override string SaveData() => $"SimpleGoal,{Name},{Points},{IsCompleted}";
    public override void LoadData(string[] parts) => IsCompleted = bool.Parse(parts[3]);
}