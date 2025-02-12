using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public static class InstructionPromptPrinter
    {
        public static void PrintWelcomeMessage() => Console.WriteLine("Welcome to Mastermind!\n\n");

        public static void PrintInstructions()
        {
            Console.WriteLine("I have set a secret code, and you have to guess what it is!");
            Console.WriteLine("The code is numeric, and is 4 digits in length.");
            Console.WriteLine("You will have 10 guesses. With each guess, I will tell you:");
            Console.WriteLine("- Whether or not your guess includes a digit that appears in the secret code");
            Console.WriteLine("- Whether the digit that appears is in a matching position to the secret code\n\n");

            Console.WriteLine("I will also validate your guess each time to make sure it's 4 digits, and is numeric.");
        }
    }
}
