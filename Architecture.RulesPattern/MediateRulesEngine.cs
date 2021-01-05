using System.Collections.Generic;

namespace DesignPatterns.RulesPattern
{
    public class MediateRulesEngine
    {
        List<IMediationRule> _rules = new List<IMediationRule>();

        public MediateRulesEngine(IEnumerable<IMediationRule> rules)
        {
            _rules.AddRange(rules);
        }

        public Usage MediateUnbillableUsage(Usage usage)
        {
            
            foreach (var rule in _rules)
            {
                usage = rule.MediateUsage(usage);
            }
            return usage;
        }
    }
}
