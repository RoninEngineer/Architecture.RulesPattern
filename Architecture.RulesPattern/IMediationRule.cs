using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.RulesPattern
{
    public interface IMediationRule
    {
        Usage MediateUsage(Usage usage);
    }
}
