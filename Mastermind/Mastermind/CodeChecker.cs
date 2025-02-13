using Mastermind.Models;
using System.Text;

namespace Mastermind
{
    public static class CodeChecker
    {
        public static string CheckCode(string userInput, string secretCode, GameOptions gameOptions)
        {
            var hintTextBuilder = new StringBuilder();
            var secretCodeDistinctDigits = secretCode.Distinct().ToList();

            foreach (int i in Enumerable.Range(0, gameOptions.NumberOfDigitsInCode))
            {
                if (userInput[i] == secretCode[i])
                {
                    hintTextBuilder.Append('+');
                    secretCodeDistinctDigits.Remove(userInput[i]);
                }
                else if (secretCodeDistinctDigits.Contains(userInput[i]))
                {
                    hintTextBuilder.Append('-');
                }
            }
            var hintText = hintTextBuilder.ToString()        
                .ToCharArray();
            // Sorting the array to group the plus and minus signs and achieve the desired output format only works because the plus sign precedes the minus sign in the UTF character map
            // We would have to group these characters in another way to retain the same behavior if hypothetically the encoding ever changed
            Array.Sort(hintText);
            
            return string.Join("", hintText);
        }
    }
}
