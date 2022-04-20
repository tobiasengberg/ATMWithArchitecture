﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreRules
{
    public class CashEvent
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public decimal CashAction { get; set; }
        public Account Account { get; set; }
        public bool Accepted { get; set; }


        public CashEvent(decimal amount, Account account)
        {
            CashAction = amount;
            Account = account;
        }

        public static bool AmountNecessary(List<CashEvent> accountHistory, int amount)
        {
            decimal totalAmount = 0;
            foreach (CashEvent cashEvent in accountHistory)
            {
                totalAmount += cashEvent.CashAction;
            }
            if (totalAmount + amount >= 0) return true;
            else return false;
            
        }

        
    }
}
