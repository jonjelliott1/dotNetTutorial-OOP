﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number { get;}
        public string Owner { get; set; }
        public decimal Balance { get;}

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawel(decimal amount, DateTime date, string note)
        {
            
        }
    }
}
