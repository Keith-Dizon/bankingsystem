using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bankingsystem
{
    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (Balance - amount < -OverdraftLimit)
            {
                Console.WriteLine("Withdrawal denied. Exceeds overdraft limit.");
                return;
            }

            Balance -= amount;

            RecordTransaction("Withdrawal", amount);

            Console.WriteLine($"{amount:C} withdrawn. Remaining Balance: {Balance:C}");
        }
    }
}