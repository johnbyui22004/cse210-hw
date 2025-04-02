public class BudgetManager
{
    private List<BudgetItem> _items;
    private decimal _savingsGoal;
    private const string FILE_PATH = "budget.txt";

    public BudgetManager(decimal savingsGoal)
    {
        _items = new List<BudgetItem>();
        _savingsGoal = savingsGoal;
        LoadFromFile();
    }

    public void AddItem(BudgetItem item)
    {
        _items.Add(item);
        SaveToFile();
    }

    public decimal CalculateTotalIncome()
    {
        decimal total = 0;
        foreach (var item in _items)
        {
            if (item is Income) total += item.Amount;
        }
        return total;
    }

    public decimal CalculateTotalExpenses()
    {
        decimal total = 0;
        foreach (var item in _items)
        {
            if (item is Expense) total += item.Amount;
        }
        return total;
    }

    private void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(FILE_PATH))
        {
            writer.WriteLine(_savingsGoal);
            foreach (var item in _items)
            {
                writer.WriteLine(item.ToFileString());
            }
        }
    }

    private void LoadFromFile()
    {
        if (!File.Exists(FILE_PATH)) return;

        using (StreamReader reader = new StreamReader(FILE_PATH))
        {
            string line;
            bool firstLine = true;
            
            while ((line = reader.ReadLine()) != null)
            {
                if (firstLine)
                {
                    _savingsGoal = decimal.Parse(line);
                    firstLine = false;
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts[0] == "Income")
                {
                    _items.Add(new Income(parts[1], decimal.Parse(parts[2]), parts[3]));
                }
                else if (parts[0] == "Expense")
                {
                    _items.Add(new Expense(parts[1], decimal.Parse(parts[2]), parts[3]));
                }
            }
        }
    }

    public void ResetBudget()
    {
        _items.Clear();
        _savingsGoal = 0m;
        SaveToFile();
        Console.WriteLine("Budget has been reset. All data cleared and savings goal set to $0.");
    }

    public void DisplayBudgetSummary()
    {
        Console.WriteLine("\n=== Budget Summary ===");
        foreach (var item in _items)
        {
            Console.WriteLine(item.GetDescription());
        }

        decimal income = CalculateTotalIncome();
        decimal expenses = CalculateTotalExpenses();
        decimal balance = income - expenses;

        Console.WriteLine($"\nTotal Income: ${income}");
        Console.WriteLine($"Total Expenses: ${expenses}");
        Console.WriteLine($"Current Balance: ${balance}");
        Console.WriteLine($"Savings Goal: ${_savingsGoal}");
        
        if (balance >= _savingsGoal)
        {
            Console.WriteLine("Congratulations! You've met your savings goal!");
        }
        else
        {
            Console.WriteLine($"You need ${(_savingsGoal - balance)} more to reach your savings goal.");
        }
    }

    public void ProvideBudgetAdvice()
    {
        decimal income = CalculateTotalIncome();
        decimal expenses = CalculateTotalExpenses();
        decimal balance = income - expenses;

        Console.WriteLine("\n=== Budget Advice ===");
        
        if (income == 0)
        {
            Console.WriteLine("You haven't added any income yet. Consider finding a source of income to start building your budget.");
            return;
        }

        decimal expensePercentage = (expenses / income) * 100;
        
        if (expensePercentage > 80)
        {
            Console.WriteLine("Warning: You're spending more than 80% of your income!");
            Console.WriteLine("Try to reduce your expenses or increase your income to save more.");
        }
        else if (expensePercentage > 50)
        {
            Console.WriteLine("You're spending over half your income.");
            Console.WriteLine("Consider reviewing your expenses to see where you can cut back.");
        }
        else
        {
            Console.WriteLine("Good job! You're keeping your expenses well below your income.");
        }

        if (balance < 0)
        {
            Console.WriteLine("You're in the red! Your expenses exceed your income.");
            Console.WriteLine("Immediate action is recommended to avoid debt.");
        }
        else if (balance < _savingsGoal / 2)
        {
            Console.WriteLine("You're making progress, but you're less than halfway to your savings goal.");
            Console.WriteLine("Try to save more each month or adjust your goal if needed.");
        }
        else
        {
            Console.WriteLine("You're on track with your savings!");
            Console.WriteLine("Keep up the good work to reach or exceed your goal.");
        }
    }
}