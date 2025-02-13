namespace Mastermind.Models
{
    enum GameRule { AllowRepeatedDigits }

    /// <summary>
    /// RuleSet will allow players to change the behavior of the game based on adoption or rejection of commonly disputed rules,
    /// such as whether or not the Codemaker's secret code may have repeating digits
    /// </summary>
    class RuleSet
    {
        private readonly Dictionary<GameRule, bool> GameRules = [];

        public RuleSet()
        {
            var ruleValues = Enum.GetValues(typeof(GameRule)).Cast<GameRule>();
            foreach (var rule in ruleValues)
            {
                GameRules.Add(rule, true);
            }
        }
    }
}
