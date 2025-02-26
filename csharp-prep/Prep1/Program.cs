using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("Please enter your name: ");
        string firstname=Console.ReadLine();
        Console.Write("Please enter your name: ");
        string lastname=Console.ReadLine();
        Console.WriteLine($"Your name is: {firstname} {lastname}");
    }
}