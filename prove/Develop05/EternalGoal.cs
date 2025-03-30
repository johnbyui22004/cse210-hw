class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent() => Points;
    public override string GetStatus() => "[∞] " + Name;
    public override string SaveData() => $"EternalGoal,{Name},{Points}";
    public override void LoadData(string[] parts) { }
}