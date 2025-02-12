using System.Transactions;

namespace Mastermind
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mastermind!\n\n");

            Console.WriteLine("I have set a secret code, and you have to guess what it is!");
            Console.WriteLine("The code is numeric, and is 4 digits in length.");
            Console.WriteLine("You will have 10 guesses. With each guess, I will tell you:");
            Console.WriteLine("- Whether or not your guess includes a digit that appears in the secret code");
            Console.WriteLine("- Whether the digit that appears is in a matching position to the secret code\n\n");

            Console.WriteLine("I will also validate your guess each time to make sure it's 4 digits, and is numeric.");
            Console.WriteLine("Let's begin!");

            var output = CodeGenerator.GenerateCode();

            int numberOfGuesses = 10;

            for (int i = 0; i < numberOfGuesses; i++)
            {
                Console.Write("Enter your guess: ");
                var guess = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(guess) || !CodeValidator.ValidateCode(guess))
                {
                    Console.WriteLine($"I'm sorry, code '{guess}' wasn't valid.");
                    continue;
                }
                Console.WriteLine("Good guess, valid guess! Wrong tho.");

            
            }

            foreach (var i in output)
            {
                Console.Write(i);
            }
        }
    }
}
