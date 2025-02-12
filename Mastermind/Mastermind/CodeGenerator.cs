namespace Mastermind
{
    public static class CodeGenerator
    {
        public static uint[] GenerateCode()
        {
            var output = new uint[4];
            var random = new Random();

            foreach (var i in Enumerable.Range(0,4))
            {
                output[i] = (uint)random.Next(1, 6);
            }
            return output;
        }
    }
}
