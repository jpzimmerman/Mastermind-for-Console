using Mastermind.Models;
using System.Diagnostics;

namespace Mastermind
{
    public static class InstructionPromptPrinter
    {
        public static void PrintWelcomeMessage() => Console.WriteLine("Welcome to Mastermind!\n\n");

        public static void PrintInstructions(GameOptions gameOptions)
        {
            Console.WriteLine("I have set a secret code, and you have to guess what it is!");
            Console.WriteLine($"The code is numeric, and is {gameOptions.NumberOfDigitsInCode} digits in length. Individual digits within the code will be between the values of {gameOptions.SmallestDigitValue} and {gameOptions.LargestDigitValue}.");
            Console.WriteLine($"You will have {gameOptions.NumberOfGuesses} guesses. With each guess, I will give you a hint about the accuracy of your guess:");
            Console.WriteLine("- If a digit in your guess is correct AND in the correct position compared to the secret code, the hint will contain a plus symbol (+)");
            Console.WriteLine("- If a digit in your guess is correct but in the wrong position compared to the secret code, the hint will contain a minus symbol (-)");
            Console.WriteLine("- If a digit is completely wrong (digit in your guess does not match any of the digits in the secret code, then nothing will be printed for that position.)");
            Console.WriteLine("\n\nExample: ");
            Console.WriteLine("Secret code: 1234");
            Console.WriteLine("Your guess: 4233");
            Console.WriteLine("Hint: ++-\n");
            Console.WriteLine($"I will also validate your guess each time to make sure it's {gameOptions.NumberOfDigitsInCode} digits in length, and that it is numeric. If your guess is invalid, you will have wasted that guess.");
        }

        public static void PrintGameWinMessage() => Console.WriteLine("You won, you guessed correctly! Please play again.");

        public static void PrintGameLossMenu() => Console.WriteLine("I'm sorry, your guesses are up. You lose.");

        public static void PrintRevealSecretCodeMessage(string secretCode) => Console.WriteLine($"The secret code was {secretCode}");


    }
}
