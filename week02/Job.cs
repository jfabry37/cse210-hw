public class Job
{
    public string _Company = "HP";
    public string _jobTitle = "Developer";
    public int _startYear = 2020;
    public int _endYear = 2023;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} at {_Company} ({_startYear} - {_endYear})");
    }
}