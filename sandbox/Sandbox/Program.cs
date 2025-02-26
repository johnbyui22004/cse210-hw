using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Hello CSE 210");
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}");
        // indentation, lines and spaces don't matter on C#

        int x =10;

        if(x != 10)
        {
            Console.WriteLine("x is not equal to 10");
        }
        else if (x == 10)
        Console.WriteLine("x is equal to 10");

    }
}
