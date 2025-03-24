class ReflectingActivity : Activity
{
    private Menu _menu; // Reference to Menu
    private Random _random = new Random(); // To select random prompts/questions

    // List of random prompts
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // List of reflective questions
    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(Menu menu)
    {
        _menu = menu;
    }

    public void StartReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("Reflecting activity started");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        Console.Write("How long in seconds would you like to do this activity? ");
        int totalSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Press any key when you're ready...");
        Console.ReadKey();
        Console.Clear();

        // Select a random prompt each time the activity starts
        string prompt = prompts[_random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("\nReflect on this prompt and answer the following questions...");

        int remainingTime = totalSeconds;
        
        // Time for each question and reflection (You can adjust this value to suit the timing)
        int questionTime = 5; // seconds for each question

        while (remainingTime > 0)
        {
            // Select a random question each time
            string question = questions[_random.Next(questions.Count)];
            Console.WriteLine($"\n{question}");
            Animation();

            // Wait for the time allocated per question (You can adjust this if needed)
            Thread.Sleep(questionTime * 1000); // Convert seconds to milliseconds

            // Decrease remaining time by the time spent on the current question
            remainingTime -= questionTime;

            // If remaining time is less than question time, break the loop
            if (remainingTime < questionTime)
            {
                break;
            }
        }

        Console.WriteLine("\nGreat job! You have completed the Reflecting activity!");
        Console.WriteLine("\nNow returning to the menu...");
        Animation();

        _menu.DisplayMenu(); // Return to the menu
    }
}
