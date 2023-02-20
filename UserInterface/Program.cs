using System;
using System.Collections.Generic;
using Application;
using CoreRules;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Transaction newTransaction = new Transaction();
            bool carryOn = true;

            while (carryOn == true)
            {
                int accountNumber = newTransaction.UserEntryAccountNumber();

                if (newTransaction.ValidateAccountNumber(accountNumber))
                {
                    HandleCashEvent(newTransaction, accountNumber);

                } else {
                    Console.WriteLine("Not a valid account number");
              
                }

            }

        }

        public static void HandleCashEvent(Transaction newTransaction, int accountNumber)
        {
            int amount = newTransaction.UserEntryAmount();
            Account account = AllAccounts.GetAccount(accountNumber);
            AllCashEvents.AddNewCashEvent(account, amount);
            if (amount > 0)
            {
                Console.WriteLine($"The amount of {amount} has been deposited to your account");
            } else
            {
                List<CashEvent> accountHistory = AllCashEvents.GetAccountHistory(account);
                if(CashEvent.AmountNecessary(accountHistory, amount))
                {
                    Console.WriteLine($"Take care of the {- amount} kr returned");
                }
                else
                {
                    Console.WriteLine("The amount is too large");
                }
            }
        }

    }
}
