using Mastermind.Models;
using Xunit;

namespace Mastermind.Tests
{
    public class CodeGeneratorTests
    {
        [Fact()]
        public void GenerateCode_DefaultOptions_ShouldGenerateValidCode()
        {
            var gameOptions = new GameOptions();

            var result = CodeGenerator.GenerateCode(gameOptions);

            var resultIntArray = result
                .ToCharArray()
                .ToList()
                .ConvertAll(x => x - '0');

            Xunit.Assert.Equal(gameOptions.NumberOfDigitsInCode, result.Length);
            Xunit.Assert.True(resultIntArray.TrueForAll(x => x >= gameOptions.SmallestDigitValue));
            Xunit.Assert.True(resultIntArray.TrueForAll(x => x <= gameOptions.LargestDigitValue));
        }
    }
}