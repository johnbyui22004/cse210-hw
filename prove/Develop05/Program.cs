class Program
{
    static void Main()
    {
        GoalTracker tracker = new GoalTracker();
        tracker.LoadGoals();
        
        while (true)
        {
            Console.WriteLine("1. Add Goal\n2. Record Event\n3. Show Goals\n4. Save & Exit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
                int type = int.Parse(Console.ReadLine());
                
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());
                
                switch (type)
                {
                    case 1:
                        tracker.AddGoal(new SimpleGoal(name, points));
                        break;
                    case 2:
                        tracker.AddGoal(new EternalGoal(name, points));
                        break;
                    case 3:
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        tracker.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                        break;
                }
            }
            else if (choice == "2")
            {
                tracker.ShowGoals();
                Console.Write("Enter goal number to record event: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                tracker.RecordEvent(index);
            }
            else if (choice == "3")
            {
                tracker.ShowGoals();
            }
            else if (choice == "4")
            {
                tracker.SaveGoals();
                break;
            }
        }
    }
}
