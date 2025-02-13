using System.Text.RegularExpressions;

namespace Mastermind
{
    public static class CodeValidator
    {
        const string codePattern = "^[1-6]{4}$";

        public static bool ValidateCode(string codeInput) => Regex.IsMatch(codeInput, codePattern);
    }
}
