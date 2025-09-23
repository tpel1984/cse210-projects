using System;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        string escapeString = "yes";

        while (escapeString.ToLower().Equals("yes"))
        {
            int guess = 0;
            int guessCount = 0;
            int magicNumber = random.Next(1, 11);

            while (guess != magicNumber)
            {
                Console.Write("\nWhat do you think the magic number is? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                
                if (guess == magicNumber)
                {
                    Console.WriteLine($"You got it in {guessCount} guesses!\n");
                    break;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }       
            }

            Console.Write("Do you want to play again? Enter Yes to play again or No to quit: ");
            escapeString = Console.ReadLine();
        }        
    }
}