class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job();

        job1.Title = "Firmware Engineer";
        job1.Company = "AMD";
        job1.StartYear = 2012;
        job1.EndYear = 2023;

        var job2 = new Job();

        job2.Title = "Software Engineer";
        job2.Company = "Intel";
        job2.StartYear = 2001;
        job2.EndYear = 2012;

        var resume = new Resume();

        resume.Name = "Friedrich Nietzsche";
        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        resume.Display();
    }
}