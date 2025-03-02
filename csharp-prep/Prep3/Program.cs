using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 

        int guess; 

        do
        {
            Console.Write("Guess the random number: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher"); // Suggests the number is too low
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower"); // Suggests the number is too high
            }
            else
            {
                Console.WriteLine("You guessed it!"); // User guessed correctly
            }

        } while (guess != magicNumber); // Loop continues until the correct number is guessed
    }
}
