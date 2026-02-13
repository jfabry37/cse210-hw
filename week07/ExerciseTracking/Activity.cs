using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

abstract class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity( DateTime date, int duration)
    {
       _date = date;
       _duration = duration;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDate(DateTime date)
    {
        _date = date;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public virtual string GetSummary()
    {
        return "";
    }
    public virtual string GetSpeed()
    {
        return "";
    }
 
    public virtual string GetDistance()
    {
        return "";
    }


    public virtual string GetPace()
    {
        return "";
    }
 



}