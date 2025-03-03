using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            
            Console.Write("Enter number:");
            userInput = int.Parse(Console.ReadLine());
            if(userInput != 0)
            {
                numbers.Add(userInput);
            }
           
        //    Could also just use .sum
        }while(userInput != 0);

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average =((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

  
    }
}