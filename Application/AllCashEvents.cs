using System;
using System.Collections.Generic;
using System.Linq;
using CoreRules;

namespace Application
{
    public static class AllCashEvents
    {
        public static List<CashEvent> cashEvents = new List<CashEvent>();

        public static CashEvent AddNewCashEvent(Account account, decimal amount)
        {
            List<CashEvent> accountHistory = GetAccountHistory(account);
            CashEvent newCashEvent = new CashEvent(amount, account, accountHistory);
            cashEvents.Add(newCashEvent);
            return newCashEvent;
        }

        public static List<CashEvent> GetAccountHistory(Account account)
        {
            List<CashEvent> relevantCashEvent = cashEvents
                .Where(c => c.Account.Number == account.Number && c.Accepted == true)
                .ToList();

            return relevantCashEvent;
        }
    }
}
