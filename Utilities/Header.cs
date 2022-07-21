using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Models;

namespace UGBANKS.Utilities
{
    public class Header
    {
        public static void header(Customer Details)
        {
            Console.Clear();
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Account Name: " + Details.FirstName.ToUpper() + " " + Details.LastName.ToUpper());
            Console.WriteLine("Account Number: " + Details.AccountNumber);
            Console.WriteLine("Accoutn Type: " + Details.AccountType);
            Console.WriteLine("Email: " + Details.Email);
            Console.WriteLine("Balance: " + Details.Balance);
            Console.WriteLine("***************************************************************");
            Console.WriteLine();
        }
    }
}
