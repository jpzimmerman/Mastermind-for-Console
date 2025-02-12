namespace Mastermind
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            InstructionPromptPrinter.PrintWelcomeMessage();
            InstructionPromptPrinter.PrintInstructions();

            Console.WriteLine("Let's begin!");

            var output = CodeGenerator.GenerateCode();

            // TESTING PURPOSES -- Let's see the code so we know the feedback is accurate
            Console.WriteLine($"The code is: {output}");
            Console.WriteLine();

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
                var feedback = CodeChecker.CheckCode(guess, output);
                Console.WriteLine(feedback);

                if (feedback == "++++")
                {
                    Console.WriteLine("You won, you guessed correctly! Please play again.");
                    break;
                }

            
            }

        }
    }
}
