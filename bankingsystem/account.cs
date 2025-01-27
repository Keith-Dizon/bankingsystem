using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bankingsystem
{
    public abstract class Account : IAccount
    {
        public string AccountHolderName { get; set; }
        protected decimal Balance { get; set; }
        private List<Transaction> transactionHistory = new List<Transaction>();

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            RecordTransaction("Deposit", amount);
            Console.WriteLine($"{amount:C} deposited. New Balance: {Balance:C}");
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public abstract void Withdraw(decimal amount);

        protected void RecordTransaction(string type, decimal amount)
        {
            transactionHistory.Add(new Transaction
            {
                Date = DateTime.Now,
                Type = type,
                Amount = amount,
                BalanceAfterTransaction = Balance
            });
        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine($"Transaction history for {AccountHolderName}:");
            if (transactionHistory.Count == 0)
            {
                Console.WriteLine("No transactions available.");
                return;
            }

            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
        public decimal CurrentBalance
        {
            get { return Balance; }
        }
    }
}
