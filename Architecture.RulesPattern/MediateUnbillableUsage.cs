using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.RulesPattern
{
    public class MediateUnbillableUsage
    {
        public Usage UnbillableUsageMediation(Usage usage)
        {
            var ruleType = typeof(IMediationRule);
            IEnumerable<IMediationRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IMediationRule);

            var engine = new MediateRulesEngine(rules);

            return engine.MediateUnbillableUsage(usage);
        }
    }
}
