class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter you grade as a percentage : ");
        
        var input = float.Parse(Console.ReadLine());

        string grade_letter;

        bool passedClass = false;
        
        if (input >= 93)
        {
            passedClass = true;
            grade_letter = "A";
        }
        else if (input >= 90) {
            passedClass = true;
            grade_letter = "A-";
        }
        else if (input >= 87)
        {
            passedClass = true;
            grade_letter = "B+";
        }
        else if (input >= 83)
        {
            passedClass = true;
            grade_letter = "B";
        }
        else if (input >= 80)
        {
            passedClass = true;
            grade_letter = "B-";
        }
        else if (input >= 77)
        {
            passedClass = true;
            grade_letter = "C+";
        }
        else if (input >= 73)
        {
            passedClass = true;
            grade_letter = "C";
        }
        else if (input >= 70)
        {
            passedClass = true;
            grade_letter = "C-";
        }
        else if (input >= 67)
        {
            grade_letter = "D+";
        }
        else if (input >= 63)
        {
            grade_letter = "D";
        }
        else if (input >= 60)
        {
            grade_letter = "D-";
        }
        else
        {
            grade_letter = "F";
        }

        if (passedClass)
        {
            Console.WriteLine($"Congrats! You passed with {grade_letter} as your grade.");
        }
        else
        {
            Console.WriteLine($"That's ok, do better next time. {grade_letter} doesn't pass the class.");
        }
    }
}