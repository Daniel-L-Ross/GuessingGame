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
            timesGuessed++;
            Console.WriteLine("Guess again: ");
            userGuess = Console.ReadLine();
            if (timesGuessed == maxGuesses)
            {
                break;
            }
        }
    }
}