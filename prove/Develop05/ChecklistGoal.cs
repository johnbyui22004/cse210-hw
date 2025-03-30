class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => (IsCompleted ? "[X] " : "[ ] ") + $"{Name} (Completed {CurrentCount}/{TargetCount})";
    public override string SaveData() => $"ChecklistGoal,{Name},{Points},{TargetCount},{BonusPoints},{CurrentCount}";
    public override void LoadData(string[] parts)
    {
        CurrentCount = int.Parse(parts[5]);
        IsCompleted = CurrentCount >= TargetCount;
    }
}