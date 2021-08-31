using System;

Main();

void Main()
{
    Console.WriteLine("Hello! You're playing the guesssing game. Try to guess the secret number!");
    string userGuess = Console.ReadLine();
    // TODO: add check for user guess
    int secretNumber = 42;
    bool correctGuess = secretNumber == Int32.Parse(userGuess);
    if (correctGuess)
    {
        Console.WriteLine("You guessed Correctly");
    }
    else
    {
        Console.WriteLine("WRONG");
    }
}