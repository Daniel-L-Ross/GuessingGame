using System;

Main();

void Main()
{
    Console.WriteLine("Hello! You're playing the guesssing game. Try to guess the secret number!");
    string userGuess = Console.ReadLine();
    // TODO: add check for user guess
    int secretNumber = 42;
    bool correctGuess = secretNumber == Int32.Parse(userGuess);
    int timesGuessed = 1;
    int maxGuesses = 4;
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
            Console.WriteLine("WRONG");
            Console.WriteLine($@"Guess again. You have made {timesGuessed} guesses.");
            if (timesGuessed == maxGuesses)
            {
                break;
            }
            timesGuessed++;
            userGuess = Console.ReadLine();
            correctGuess = secretNumber == Int32.Parse(userGuess);
        }
    }
}