// John Earl
using System;
using System.Collections.Generic;

public class Program
{
    private static Scripture scripture;
    private static Random rand = new Random(); // Moved Random instance here for better randomness

    public static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true.")
        };

        scripture = scriptures[rand.Next(scriptures.Count)];

        Run();
    }

    public static void Run()
    {
        bool continueGame = true;

        while (continueGame)
        {
            Console.Clear();
            Console.WriteLine("Scripture: ");
            Console.WriteLine(scripture.GetFormattedScripture());

            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                continueGame = false;
            }
            else
            {
                scripture.HideRandomWord();
            }
        }

        Console.WriteLine("Scripture memorization complete! Press Enter to exit.");
        Console.ReadLine();
    }
}
