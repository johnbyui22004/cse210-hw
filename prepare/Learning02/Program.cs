using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job myFirstJob = new Job("Microsoft", "Software Engineer", 2010, 2012);
        Job mySecondJob = new Job("Google", "Software Engineer", 2012, 2014);
        // myFirstJob.DisplayJob();
        // mySecondJob.DisplayJob();
        Resume myResume = new Resume("Jon crow");
        myResume.addJob(myFirstJob);
        myResume.addJob(mySecondJob);
        myResume.DisplayResume();
    }
}