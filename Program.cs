using System;

Main();

void Main()
{
    Console.WriteLine("Hello! You're playing the guesssing game. Try to guess the secret number between 1 - 1000!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("| Select a Difficulty                       |");
    Console.WriteLine("|                                           |");
    Console.WriteLine("| 1) Easy   - 8 guesses.                    |");
    Console.WriteLine("| 2) Medium - 6 guesses.                    |");
    Console.WriteLine("| 3) Hard   - 4 guesses.                    |");
    Console.WriteLine("| 4) Cheat  - infinite guesses.             |");
    Console.WriteLine("| 5) Exit.                                  |");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    string difficulty = Console.ReadLine();
    int maxGuesses = 0;
     while (difficulty != "1" && difficulty != "2" && difficulty != "3" && difficulty != "4" && difficulty != "5")
    {
        Console.WriteLine("Please choose an option listed above");
        difficulty = Console.ReadLine();
    }
    if (difficulty == "1")
    {
    maxGuesses = 8;
    }
    else if (difficulty == "2")
    {
    maxGuesses = 6;
    }
    else if (difficulty == "3")
    {
    maxGuesses = 4;
    }
    else if (difficulty == "4")
    {
    maxGuesses = int.MaxValue;
    }
    else if (difficulty =="5")
    {
        Console.WriteLine("Thanks for stopping by!");
        Environment.Exit(0);
    }
    Console.WriteLine($@"You have {maxGuesses} remaining. Enter your first guess.");
    string userGuess = Console.ReadLine();
    // TODO: add check for user guess
    Random randomInt = new Random();
    int secretNumber = randomInt.Next(1, 1000);
    bool correctGuess = secretNumber == Int32.Parse(userGuess);
    int timesGuessed = 1;
    bool keepRunning = true;
    while (keepRunning)
    {
        if (correctGuess)
        {
            Console.WriteLine("You guessed Correctly");
            keepRunning = false;
        }
        else
        {
            string guessPosition = "";
            if (Int32.Parse(userGuess) > secretNumber)
            {
                guessPosition = "high";
            }
            else
            {
                guessPosition = "low";
            }
            Console.WriteLine($@"WRONG. You guessed too {guessPosition}.");
            Console.WriteLine($@"You have {maxGuesses - timesGuessed} of {maxGuesses} guesses left.");
            if (timesGuessed == maxGuesses)
            {
                break;
            }
            Console.WriteLine("Guess again");
            timesGuessed++;
            userGuess = Console.ReadLine();
            correctGuess = secretNumber == Int32.Parse(userGuess);
        }
    }
    Console.WriteLine($@"The secret number was {secretNumber}. Play again!");
}