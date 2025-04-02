class Program
{
    static void Main(string[] args)
    {
        BudgetManager budget = new BudgetManager(1000m);

        // Display initial budget from file (if exists)
        budget.DisplayBudgetSummary();

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1 = Add Income");
            Console.WriteLine("2 = Add Expense");
            Console.WriteLine("3 = Get Budget Advice");
            Console.WriteLine("0 = Exit");
            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Name: ");
                    string incomeName = Console.ReadLine();
                    Console.Write("Amount: ");
                    decimal incomeAmount = decimal.Parse(Console.ReadLine());
                    Console.Write("Source: ");
                    string source = Console.ReadLine();
                    budget.AddItem(new Income(incomeName, incomeAmount, source));
                    budget.DisplayBudgetSummary();
                    break;

                case "2":
                    Console.Write("Name: ");
                    string expenseName = Console.ReadLine();
                    Console.Write("Amount: ");
                    decimal expenseAmount = decimal.Parse(Console.ReadLine());
                    Console.Write("Category: ");
                    string category = Console.ReadLine();
                    budget.AddItem(new Expense(expenseName, expenseAmount, category));
                    budget.DisplayBudgetSummary();
                    break;

                case "3":
                    budget.ProvideBudgetAdvice();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}