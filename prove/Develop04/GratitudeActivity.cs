class GratitudeActivity : Activity
{
    private Menu _menu;
    private Random _random = new Random(); // For randomizing prompts

    // List of gratitude prompts
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What is something that made you smile today?",
        "What are you thankful for about your health?",
        "What is something positive that happened recently?",
        "What are you thankful for about your home?"
    };

    public GratitudeActivity(Menu menu)
    {
        _menu = menu;
    }

    public void StartGratitudeActivity()
    {
        Console.Clear();
        Console.WriteLine("Gratitude activity started");
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by thinking about things you're grateful for.");
        
        Console.Write("How many items would you like to list? ");
        int totalSeconds = int.Parse(Console.ReadLine()); // User input for the activity duration
        Console.WriteLine("Press any key when you're ready...");
        Console.ReadKey();

        // Select random prompt
        string prompt = prompts[_random.Next(prompts.Count)];
        Console.Clear();
        Console.WriteLine(prompt);
        Console.WriteLine("\nGet ready to list Things you are grateful for");

        // Countdown before starting
        Animation();

        int itemsListed = 0;
        int remainingTime = totalSeconds;

        while (remainingTime > 0)
        {
            Console.Write("\nEnter something you're grateful for: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                itemsListed++; // Increment item count if the user entered something
            }

            // Wait for 1 second before allowing the next input (gives the user a moment to think)
            Thread.Sleep(1000); 

            remainingTime--; // Decrease remaining time for each cycle (each input)

            // If remaining time is up, end the activity
            if (remainingTime <= 0) break;
        }

        Console.Clear();
        Console.WriteLine($"\nYou listed {itemsListed} things you're grateful for!");
        Console.WriteLine("\nGratitude activity complete!");
        Console.WriteLine("\nNow returning to the menu...");
        
        Animation();  // Call the animation from the base class
        _menu.DisplayMenu(); // Return to the menu
    }
}
