class Job
{
    private string _companyName;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    public Job(string companyName, string jobTitle, int startYear, int endYear)
    {
        this._companyName = companyName;
        this._jobTitle = jobTitle;
        this._startYear = startYear;
        this._endYear = endYear;
    }

    public void DisplayJob()
    {
        Console.WriteLine($"Job information: Company: {_companyName}, Job Title: {_jobTitle}, Start Year: {_startYear}, End Year: {_endYear}");
    }

    

}