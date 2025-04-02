public class Income : BudgetItem
{
    private string _source;

    public Income(string name, decimal amount, string source) : base(name, amount)
    {
        _source = source;
    }

    public override string GetDescription()
    {
        return $"Income - {Name}: ${Amount} from {_source}";
    }

    public override string ToFileString()
    {
        return $"Income|{Name}|{Amount}|{_source}";
    }
}