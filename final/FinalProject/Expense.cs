public class Expense : BudgetItem
{
    private string _category;

    public Expense(string name, decimal amount, string category) : base(name, amount)
    {
        _category = category;
    }

    public override string GetDescription()
    {
        return $"Expense - {Name}: ${Amount} in category {_category}";
    }

    public override string ToFileString()
    {
        return $"Expense|{Name}|{Amount}|{_category}";
    }
}