class ListingActivity : Activity
{
    private Menu _menu; // Reference to Menu
    private Random _random = new Random(); // To select random prompts

    // List of random prompts
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(Menu menu)
    {
        _menu = menu;
    }

    public void StartListingActivity()
    {
        Console.Clear();
        Console.WriteLine("Listing activity started");
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        Console.Write("How long in seconds would you like to do this activity? ");
        int totalSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Press any key when you're ready...");
        Console.ReadKey();

        // Select random prompt
        string prompt = prompts[_random.Next(prompts.Count)];
        Console.Clear();
        Console.WriteLine(prompt);
        Console.WriteLine("\nGet ready to list as many things as you can!");

        // Countdown before starting the list
        StartCountdown(5);

        int remainingTime = totalSeconds;
        int itemsListed = 0;

        while (remainingTime > 0)
        {
            Console.Write("\nEnter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item)) itemsListed++;

            remainingTime--;
            Thread.Sleep(1000); // Wait for 1 second between entries
        }

        Console.WriteLine($"\nYou listed {itemsListed} items!");
        Console.WriteLine("\nListing activity complete!");
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
        
        _menu.DisplayMenu(); // Return to the menu
    }
}
