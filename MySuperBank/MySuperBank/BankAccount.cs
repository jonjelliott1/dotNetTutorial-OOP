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
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                
                }
                return balance;
            }
        }
        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            MakeDeposit(initialBalance,DateTime.Now, "Initial Balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
     if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }


        public void MakeWithdrawel(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not suffcient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }


        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                //Rows
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}
