using System;
using CoreRules;
using Application;
namespace UserInterface

{
    public class Transaction
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Transaction()
        {
            StartTime = DateTime.Now;
        }

        public void EndTransaction()
        {
            EndTime = DateTime.Now;
        }

        public int UserEntryAmount()
        {
            Console.Write("Enter an amount to withdraw or deposit: ");
            string userEntry = Console.ReadLine();
            int amount = int.Parse(userEntry);
            return amount;
        }

        public int UserEntryAccountNumber()
        {
            Console.Write("Enter your account number: ");
            string userEntry = Console.ReadLine();
            int accountNumber = int.Parse(userEntry);
            return accountNumber;
        }

        public bool ValidateAccountNumber(int number)
        {
            return AllAccounts.FindAccountNumber(number);           
        }
    }
}
