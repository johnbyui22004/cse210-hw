class Resume
{
    private string _name;
    private List<Job> _jobs;

    public Resume(string name)
    {
        this._name = name;
        this._jobs = new List<Job>();
    }

    public void addJob(Job job)
    {
        _jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Resume for {_name}:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}