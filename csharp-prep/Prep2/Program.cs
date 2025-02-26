using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeAnswer = Console.ReadLine();
        int gradePercentage = int.Parse(gradeAnswer);

        string letter=" ";

        if (gradePercentage >= 90)
        {
            letter="A";
        }
        else if (gradePercentage >= 80)
        {
            letter="B";
        }
        else if (gradePercentage >= 70)
        {
            letter="C";
        }
        else if (gradePercentage >= 60)
        {
            letter="D";
        }
        else 
        {
            letter="F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (gradePercentage>=70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("You've got it next time!");
        }
    }
}