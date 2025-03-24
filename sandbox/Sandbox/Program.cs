using System;


class Program
{
    static void RunSpinner()
    {
        int counter =0;
        string[] spinnerString = {"-", "+"};
        while(counter < 10)
        {
            Console.Write($"{spinnerString[counter % 2]}");
            Console.Write("\b\b");
            Thread.Sleep(200);
            counter++;

        }
       

    }
    static void Main(string[] args)
    {
        RunSpinner();
        
    }

    

    
}
