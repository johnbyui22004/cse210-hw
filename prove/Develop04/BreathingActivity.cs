class BreathingActivity : Activity
{
    private Menu _menu;
        public BreathingActivity(Menu menu)
    {
        _menu = menu;
    }
    public void StartBreathingActivity()
    {
        Console.WriteLine("Breathing activity started");
        Console.WriteLine("\nThis activity is designed to help you relax and focus on your breathing.");
        Console.Write("How long in seconds would you like to do this activity? ");
        
        int totalSeconds = int.Parse(Console.ReadLine()); // User input
        Console.WriteLine("OK, press any key when ready...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Ok, Get Ready...");
        Animation();

        int timeRemaining = totalSeconds;

        while (timeRemaining >= 4)
        {
            Console.Write("\nBreath in... ");
            StartCountdown(Math.Min(4, timeRemaining));
            timeRemaining -= 4;
            if (timeRemaining <= 0) break;

            Console.Write("\nHold... ");
            StartCountdown(Math.Min(4, timeRemaining));
            timeRemaining -= 4;
            if (timeRemaining <= 0) break;

            Console.Write("\nBreath out... ");
            StartCountdown(Math.Min(4, timeRemaining));
            timeRemaining -= 4;
        }

        Console.WriteLine($"\nGood job!! you completed {totalSeconds} Seconds of Breathing Excersize! Returning to Menu...\n");
        Animation();
        _menu.DisplayMenu();
        
    }
}