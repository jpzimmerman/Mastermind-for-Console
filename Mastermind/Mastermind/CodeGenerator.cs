using Mastermind.Models;
using System.Text;

namespace Mastermind
{
    public static class CodeGenerator
    {
        public static string GenerateCode(GameOptions gameOptions)
        {
            var output = new StringBuilder();
            var randomNumberGenerator = new Random();

            try
            {
                foreach (var i in Enumerable.Range(0, gameOptions.NumberOfDigitsInCode))
                {
                    output.Append(randomNumberGenerator.Next(gameOptions.SmallestDigitValue, gameOptions.LargestDigitValue + 1));
                }
                return output.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GenerateCode() exception: {ex.Message}");
                //calling GenerateCode() with a new GameOptions()object should generate a code with default values and bypass any bad configuration that likely caused the error
                return GenerateCode(new GameOptions());
            }
        }
    }
}
