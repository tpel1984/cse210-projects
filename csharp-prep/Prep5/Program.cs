using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        var userName = PromptUserName();
        var userNumber = PromptUserNumber();

        int userBirthYear;

        PromptUserBirthYear(out userBirthYear);

        var squaredNum = SquareNumber(userNumber);
        DisplayResult(userName, userBirthYear, squaredNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write("\nEnter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("\nEnter an integer: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write("\nEnter your birth year: ");
        userBirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int birthYear, int squaredNum)
    {
        int age = 2025 - birthYear;
        Console.WriteLine($"{name}, your number squared is {squaredNum}.");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}