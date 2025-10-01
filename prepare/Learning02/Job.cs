public class Job
{
    public string Company;
    public string Title;
    public int StartYear;
    public int EndYear;
    
    public void Display()
    {
        Console.WriteLine($"{Title} at {Company} {StartYear}-{EndYear}");
    }
}