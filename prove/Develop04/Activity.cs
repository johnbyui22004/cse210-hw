using System;
using System.Threading;
using System.Collections.Generic;

class Activity
{
    public void Animation()
    {
        List<string> newAnimation = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        Console.CursorVisible = false; // Hide cursor for smooth animation
        foreach (string item in newAnimation)
        {
            Console.Write("\r" + item + " "); // Overwrites the same line
            Thread.Sleep(250);
        }
        Console.Write("\r   \r"); // Clears animation after loop
        Console.CursorVisible = true;
    }

    public void StartCountdown(int seconds)
    {
        Console.WriteLine($"{seconds}");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}"); // Fix: Uses i instead of _seconds
            Thread.Sleep(1000);
        }
        Console.Write("\r \n"); // Clears last number
    }
}