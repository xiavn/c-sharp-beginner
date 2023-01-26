using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int totalGuesses = 0;
            int currentGuess = 0;
            bool keepGuessing = true;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            do {
                Console.WriteLine("What's your guess?");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out currentGuess);
                if (!isNumber) {
                    Console.WriteLine("That doesn't look like a valid number!");
                }
                else if (currentGuess == -1) {
                    Console.WriteLine($"Thanks for playing! The number was {theNumber} by the way!");
                    keepGuessing = false;
                } else {
                    bool suitableGuess = currentGuess >= 0 && currentGuess <= 20;
                    if (suitableGuess) {
                        totalGuesses++;
                        if (currentGuess == theNumber) {
                            string guessStr = totalGuesses > 1 ? "guesses" : "guess";
                            Console.WriteLine("Well done! You got it correct!");
                            Console.WriteLine($"It took you {totalGuesses} {guessStr}.");
                            keepGuessing = false;
                        } else if (currentGuess > theNumber) {
                            Console.WriteLine("Nope! Lower than that!");
                        } else if (currentGuess < theNumber) {
                            Console.WriteLine("Nope! You need to go higher than that!");
                        }
                    } else {
                        Console.WriteLine("Please enter a valid number between 0 and 20.");
                    }
                }
                
                
            } while (keepGuessing);
        }
    }
}
