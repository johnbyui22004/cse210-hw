class Menu
{
    private int _selectedNumber;

    public void DisplayMenu()
    {
        Thread.Sleep(5000); // Delay for better user experience
        Console.Clear();
        Console.WriteLine("Menu options:");
        Console.WriteLine(" 1. Start Breathing activity");
        Console.WriteLine(" 2. Start Reflecting activity");
        Console.WriteLine(" 3. Start Listing activity");
        Console.WriteLine(" 4. Exit");
        Console.Write("Please select an option: ");
        
        if (!int.TryParse(Console.ReadLine(), out _selectedNumber))
        {
            Console.WriteLine("ERROR: Please enter a valid number.");
            DisplayMenu();
            return;
        }

        switch (_selectedNumber)
        {
            case 1:
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity(this); // Pass `this` (Menu instance)
                breathingActivity.StartBreathingActivity();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Reflecting activity started");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Listing activity started");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Exiting...");
                return;
            default:
                Console.WriteLine("ERROR: Please enter a number from 1-4.");
                DisplayMenu();
                break;
        }
    }
}
