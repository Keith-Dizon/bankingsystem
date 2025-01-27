using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount
            {
                AccountHolderName = "Keith Andrei Dizon"
            };

            savings.Deposit(500m);
            savings.Withdraw(300m);
            savings.ResetWithdrawalLimit();
            savings.Withdraw(200m);

            Console.WriteLine($"Savings Account - Holder: {savings.AccountHolderName}, Balance: {savings.CurrentBalance:C}");
            Console.WriteLine();
            savings.ShowTransactionHistory();

            Console.WriteLine();

            CheckingAccount checking = new CheckingAccount
            {
                AccountHolderName = "Rhandy Dizon",
                OverdraftLimit = 200m
            };

            checking.Deposit(300m);
            checking.Withdraw(600m);
            checking.Withdraw(200m);

            Console.WriteLine($"Checking Account - Holder: {checking.AccountHolderName}, Balance: {checking.CurrentBalance:C}");
            Console.WriteLine();
            checking.ShowTransactionHistory();
        }
    }
}
