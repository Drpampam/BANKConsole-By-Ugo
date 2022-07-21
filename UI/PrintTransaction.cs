using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Models;

namespace UGBANKS.UI
{
    public class PrintTransaction
    {
        public static void print(Customer Details, List<Transactions> tranc)
        {
            List<Transactions> transactions = tranc.FindAll(x => x.AccNumber == Details.AccountNumber);
            Console.Clear();
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Account Name: " + Details.FirstName.ToUpper() + " " + Details.LastName.ToUpper());
            Console.WriteLine("Account Number: " + Details.AccountNumber);
            Console.WriteLine("Accoutn Type: " + Details.AccountType);
            Console.WriteLine("Email: " + Details.Email);
            Console.WriteLine("Balance: " + Details.Balance);
            Console.WriteLine("***************************************************************");
            Console.WriteLine();
            Console.WriteLine("ACCOUNT STATEMENT OF ACCOUNT NUMBER " + Details.AccountNumber);

            if (transactions.Count > 0)
            {
                Console.WriteLine($"| {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} |");
                Console.WriteLine($"| {"DATE",-20} | {"DESCRIPTION",-20} | {"AMOUNT",-20} | {"ACCOUNT BALANCE",-20} |");
                Console.WriteLine($"| {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} |");


                foreach (var trans in transactions)
                {
                    Thread.Sleep(300);
                    Console.WriteLine($"| {trans.Date,-20} | {trans.Description,-20} | {trans.Amount,-20} | {trans.CurrentBalance,-20} |");
                }


                Console.WriteLine($"| {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} |");
            }
            else
            {
                Console.WriteLine("NO RECORDS FOUND");
            }
        }

    }
}
