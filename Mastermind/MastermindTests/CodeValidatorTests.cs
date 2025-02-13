using Xunit;

namespace Mastermind.Tests
{
    public class CodeValidatorTests
    {
        [Fact()]
        public void ValidateCode_ValidCode_ShouldReturnTrue()
        {
            var testCode = "1234";

            var result = CodeValidator.ValidateCode(testCode);

            Xunit.Assert.True(result);
        }

        [Fact()]
        public void ValidateCode_InvalidCode_ShouldReturnFalse()
        {
            var testCode = "9999"; //since default parameters specify that the code's digits can only be between 1 and 6, "9999" should be an invalid code

            var result = CodeValidator.ValidateCode(testCode);

            Xunit.Assert.False(result);
        }

        [Fact()]
        public void ValidateCode_NonNumeric_ShouldReturnFalse()
        {
            var testCode = "abby normal";

            var result = CodeValidator.ValidateCode(testCode);

            Xunit.Assert.False(result);
        }
    }
}