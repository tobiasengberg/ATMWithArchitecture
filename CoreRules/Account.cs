using System;
namespace CoreRules
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public int ClearingNumber { get; private set; }
        public bool AccountActive { get; private set; }
        public DateTime LatestAction { get; set; }  
        
        public Account(int accountNumber, int clearingNumber)
        {
            AccountNumber = accountNumber;
            ClearingNumber = clearingNumber;
            AccountActive = true;
            LatestAction = DateTime.Now;
        }

        public AccountClosure CloseAccount(AccountClosure accountClosure)
        {
            DateTime transactionMoment = DateTime.Now;
            AccountActive = false;
            LatestAction = transactionMoment;
            accountClosure.ClosureSuccessful = true;
            accountClosure.ClosureDate = transactionMoment;
            return accountClosure;
        }
        
        public bool ReOpenAccount()
        {
            if (AccountActive == false && LatestAction.AddYears(AccountRules.ReOpenYearLimit) > DateTime.Now)
            {
                AccountActive = true;
                LatestAction = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}
