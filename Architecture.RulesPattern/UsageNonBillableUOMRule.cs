using System;
using System.Collections.Generic;

namespace DesignPatterns.RulesPattern
{
    public class UsageNonBillableUOMRule : IMediationRule
    {
        
        public Usage MediateUsage(Usage usage)
        {
            if(!CheckBillableUOMS(usage))
            {
                usage.ExcludeFromBilling = true;
                usage.ExcludeFromBillingReason = "Non-billable UOM";
            }
            return usage;
        }

        private bool CheckBillableUOMS(Usage usage)
        {
            List<string> _billableUOMs = new List<string> { "item1", "item2", "item3" };
            return _billableUOMs.Contains(usage.UOM);
        }


    }
}
