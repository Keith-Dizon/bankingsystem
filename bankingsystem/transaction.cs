using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingsystem
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public decimal BalanceAfterTransaction { get; set; }

        public override string ToString()
        {
            return $"{Date}: {Type} of {Amount:C}, Balance: {BalanceAfterTransaction:C}";
        }
    }
}
