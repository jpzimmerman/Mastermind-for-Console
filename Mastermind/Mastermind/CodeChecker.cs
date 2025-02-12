using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public static class CodeChecker
    {
        public static string CheckCode(string userInput, string secretCode)
        {
            var output = new StringBuilder();

            foreach (int i in Enumerable.Range(0, 4))
            {
                if (userInput[i] == secretCode[i])
                {
                    output.Append('+');
                }
                else if (secretCode.Contains(userInput[i]))
                {
                    output.Append('-');
                }
            }
            var readyOutput = output.ToString()        
                .ToCharArray();
            //this array sort orders the plus signs before the minus signs
            Array.Sort(readyOutput);
            
            return string.Join("", readyOutput);
        }
    }
}
