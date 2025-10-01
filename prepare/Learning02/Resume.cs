public class Resume
{
    public string Name;
    public List<Job> Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{Name}");

        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}