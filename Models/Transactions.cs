using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Models
{
    public class Transactions
    {

        public string Date;
        public string AccNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrentBalance { get; set; }

        public Transactions(string date, string accNumber, string description, decimal amount, decimal currentBalance)
        {
            Date = date;
            AccNumber = accNumber;
            Description = description;
            Amount = amount;
            CurrentBalance = currentBalance;
        }
    }
}
