using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Codemaker
    {
        private readonly string secretCode;

        public Codemaker()
        {
            secretCode = CodeGenerator.GenerateCode();
        }

        public char[] CheckCode()
        {
            var output = new char[4];

            foreach (var i in Enumerable.Range(0, 4))
            {

            }

            return output;
        }
    }
}
