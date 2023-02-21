using System;

namespace CoreRules
{
    public class AccountRules
    {
        public static readonly int ReOpenDaysLimit = 2 * 365;

        public static bool IsReOpenable(DateTime comparable)
        {
            return DateTime.Now < comparable.AddDays(ReOpenDaysLimit);
        }
    }
}