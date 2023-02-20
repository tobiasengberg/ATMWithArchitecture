using System;

namespace CoreRules
{
    public class AccountClosure
    {
        public DateTime ClosureDate { get; set; }
        public Account Account { get; set; }
        public bool ClosureSuccessful { get; set; }
        public ClosureCause Cause { get; set; }
    }
}