using System.Text;

namespace Mastermind
{
    public static class CodeGenerator
    {
        public static string GenerateCode()
        {
            var output = new StringBuilder();
            var random = new Random();

            foreach (var i in Enumerable.Range(0,4))
            {
                output.Append(random.Next(1, 6));
            }
            return output.ToString();
        }
    }
}
