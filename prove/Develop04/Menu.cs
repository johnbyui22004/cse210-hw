class Menu
{
    private int _selectedNumber;

    private Menu _menu; // Reference to Menu

  

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu options:");
        
        Console.WriteLine(" 1. Start Breathing activity");
        Console.WriteLine(" 2. Start Reflecting activity");
        Console.WriteLine(" 3. Start Listing activity");
        Console.WriteLine(" 4. Exit");
        Console.Write("Please select an option: ");
        _selectedNumber = int.Parse(Console.ReadLine());

        switch (_selectedNumber)
        {
            case 1:
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartBreathingActivity();
                break;
            case 2:

                break;
            case 3:
                Console.WriteLine("Listing activity started");
                break;
            case 4:
                Console.WriteLine("Exiting");
                break;
            default:
                Console.WriteLine("ERROR: Please enter an Integer from 1-4");
                break;
        }
    }


}