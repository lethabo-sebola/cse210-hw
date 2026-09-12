using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guessCount = 0;

        Console.WriteLine("What is your guess for the magic number (1-100)?");
        int userGuess = int.Parse(Console.ReadLine());

        guessCount++;

        while (userGuess != magicNumber)
        {
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }

            Console.WriteLine("What is your guess for the magic number (1-100)?");
            userGuess = int.Parse(Console.ReadLine());

            guessCount++;
        }

        Console.WriteLine("Congratulations! You guessed the magic number.");
        Console.WriteLine($"It took you {guessCount} guesses.");
    }
}