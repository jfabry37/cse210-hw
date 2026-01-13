public class Job
{
    public string _Company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} at {_Company} from {_startYear} to {_endYear}");
    }
    
}