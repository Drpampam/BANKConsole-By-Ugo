using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Models;

namespace UGBANKS.UI
{
    public class PrintAccounts
    {
        public static void print(List<Customer> Details, Customer user)
        {
            List<Customer> accounts = Details.FindAll(x => x.Email == user.Email);
            Console.Clear();
            
            Console.WriteLine("You have " + accounts.Count + " account(s) with UGBANKS");
            Console.WriteLine($"| {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} |");
            Console.WriteLine($"| {"FULLNAME",-20} | {"ACCOUNT NUMBER",-20} | {"ACCOUNT TYPE",-20} | {"BALANCE",-20} |");
            Console.WriteLine($"| {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} |");

            foreach (var account in accounts)
            {
                Thread.Sleep(300);
                Console.WriteLine($"| {account.FirstName.ToLower() + " " + account.LastName.ToLower(),-20} | {account.AccountNumber,-20} | {account.AccountType,-20} | {account.Balance,-20} |");
            }
            Console.WriteLine($"| {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} | {"--------------------",-20} |");

        }
    }
}
