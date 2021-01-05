namespace DesignPatterns.RulesPattern
{
    public class UsageZeroQuantityRule : IMediationRule
    {
        public Usage MediateUsage(Usage usage)
        {
            if(usage.Quantity == 0)
            {
                usage.ExcludeFromBilling = true;
                usage.ExcludeFromBillingReason = "Zero quantity usage";
            }

            return usage;
        }
    }
}
