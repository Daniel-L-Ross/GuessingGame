using System;

Main();

void Main()
{
    Console.WriteLine("Hello! You're playing the guesssing game. Try to guess the secret number!");
    string userGuess = Console.ReadLine();
    Console.WriteLine($@"You guessed {userGuess}.");
}