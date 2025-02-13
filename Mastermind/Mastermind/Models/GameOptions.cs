namespace Mastermind.Models
{
    public class GameOptions
    {
        public int NumberOfDigitsInCode { get; set; } = 4;
        public int NumberOfGuesses { get; set; } = 10;
        public int SmallestDigitValue { get; set; } = 1;
        public int LargestDigitValue { get; set; } = 6;
    }
}
