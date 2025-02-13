using Mastermind.Models;
using Microsoft.Extensions.Configuration;

namespace Mastermind
{
    static internal class Program
    {
        static void Main()
        {
            #region Load Game Configuration from appsettings.json
            var configBuilder = new ConfigurationBuilder();
            configBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", 
                              optional: false, 
                              reloadOnChange: true);

            var gameOptions = new GameOptions();
            configBuilder.Build()
                .GetSection("GameOptions")
                .Bind(gameOptions);

            // In the interest of time, we'll pass this gameOptions variable to every part of the code that needs it, and worry about dependency injection at a later date
            #endregion

            InstructionPromptPrinter.PrintWelcomeMessage();
            InstructionPromptPrinter.PrintInstructions(gameOptions);

            var ruleSet = new RuleSet();

            Console.WriteLine("Let's begin!");

            try
            {
                var secretCode = CodeGenerator.GenerateCode(gameOptions);

                // TESTING PURPOSES -- Let's see the code so we know the feedback is accurate
                //Console.WriteLine($"The code is: {secretCode}");
                //Console.WriteLine();

                foreach (var i in Enumerable.Range(0, gameOptions.NumberOfGuesses))
                {
                    Console.Write($"Guess #{i + 1}. Enter your guess: ");
                    var playerGuess = Console.ReadLine()?.Trim();

                    if (string.IsNullOrEmpty(playerGuess) || !CodeValidator.ValidateCode(playerGuess))
                    {
                        Console.WriteLine($"I'm sorry, code '{playerGuess}' wasn't valid.");
                        continue;
                    }
                    var codemakerAnswer = CodeChecker.CheckCode(playerGuess, secretCode, gameOptions);
                    Console.WriteLine($"Codemaker Hint: {codemakerAnswer}");

                    if (codemakerAnswer == "++++")
                    {
                        Console.WriteLine("You won, you guessed correctly! Please play again.");
                        return;
                    }
                }

                // if we've reached this point, then we've expended all of our guesses and didn't get the right answer
                InstructionPromptPrinter.PrintGameLossMenu();
                InstructionPromptPrinter.PrintRevealSecretCodeMessage(secretCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Main program loop exception: {ex.Message}");
                return;
            }
        }
    }
}
