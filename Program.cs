using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int attempts = 0;

            Console.WriteLine("--- Number Guessing Game ---");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Can you guess what it is?");
            Console.WriteLine("Type your guess or 'exit' to quit.");

            while (true)
            {
                Console.Write("\nEnter your guess: ");
                string input = Console.ReadLine()?.ToLower();

                if (input == "exit")
                {
                    Console.WriteLine($"You exited the game. The number was: {targetNumber}");
                    break;
                }

                if (int.TryParse(input, out int guess))
                {
                    attempts++;

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }    
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100, or type 'exit' to quit.");
                }
            }
            Console.WriteLine("Thanks for playing! Goodbye!");
            Console.WriteLine("-----------------------------");

        }
    }
}
