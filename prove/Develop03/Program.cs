using System;

public class Program
{
    private static Scripture scripture;

    public static void Main()
    {
        // Create a reference for the scripture
        Reference reference = new Reference("John", 3, 16);
        
        // Create a scripture instance with the reference and text
        string text = "For God so loved the world that he gave his only begotten Son.";
        scripture = new Scripture(reference, text);
        
        // Start the program
        Run();
    }

    public static void Run()
    {
        bool continueGame = true;

        while (continueGame)
        {
            // Display the full scripture with reference
            Console.Clear();
            Console.WriteLine("Scripture: ");
            Console.WriteLine(scripture.GetFormattedScripture());
            
            // Ask for user input
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                continueGame = false;
            }
            else
            {
                // Hide a word in the scripture
                scripture.HideRandomWord();
                
                // Continue the loop
            }
        }

        Console.WriteLine("Scripture memorization complete! Press Enter to exit.");
        Console.ReadLine();
    }
}
