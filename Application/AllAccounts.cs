using System;
using System.Collections.Generic;
using CoreRules;

namespace Application
{
    public static class AllAccounts
    {
        public static List<Account> accounts = new List<Account>()
        {
            new Account(2356),
            new Account(9288)
        };

        public static void NewAccount(int number)
        {
            Account newAccount = new Account(number);
            accounts.Add(newAccount);
        }

        public static bool FindAccountNumber(int number)
        {
            bool numberFound = false;
            foreach (Account account in accounts)
            {
                if(account.Number == number)
                {
                    numberFound = true;
                    return numberFound;
                };
            }
            return numberFound;

        }

        public static Account GetAccount(int number)
        {
            return accounts.Find(account => account.Number == number);
        }
        
    }
}
