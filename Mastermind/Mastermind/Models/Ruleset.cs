namespace Mastermind.Models
{
    enum GameRule { AllowRepeatedDigits }

    class RuleSet
    {
        private readonly Dictionary<GameRule, bool> GameRules = new Dictionary<GameRule, bool>();

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
