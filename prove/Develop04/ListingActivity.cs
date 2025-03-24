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

        // Start tracking time from now
        int itemsListed = 0;
        DateTime startTime = DateTime.Now;
        Console.Clear();
                string prompt = prompts[_random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("\nGet ready to list as many things as you can!");
        Animation();
        while (true)
        {




 

            // Check if the total time has passed
            if ((DateTime.Now - startTime).TotalSeconds >= totalSeconds)
            {
                break;
            }

            Console.Write("\nEnter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item)) 
            {
                itemsListed++;
            }

        }

        Console.WriteLine($"\nGood job you listed {itemsListed} items!");
        Console.WriteLine("\nListing activity complete!");
        Console.WriteLine("\nNow returning to the menu...");
        
        Animation();
        
        _menu.DisplayMenu(); // Return to the menu
    }
}
