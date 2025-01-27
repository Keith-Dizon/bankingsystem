using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bankingsystem
{
    public class SavingsAccount : Account
    {
        private bool hasWithdrawnToday = false;

        public override void Withdraw(decimal amount)
        {
            if (hasWithdrawnToday)
            {
                Console.WriteLine("Withdrawal denied. Only one withdrawal allowed per day.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Withdrawal denied. Insufficient balance.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            Balance -= amount;
            hasWithdrawnToday = true;

            RecordTransaction("Withdrawal", amount);

            Console.WriteLine($"{amount:C} withdrawn. Remaining Balance: {Balance:C}");
        }

        public void ResetWithdrawalLimit()
        {
            hasWithdrawnToday = false;
        }
    }
}