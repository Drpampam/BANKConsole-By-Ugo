using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Auth;
using UGBANKS.Helpers;
using UGBANKS.Models;
using UGBANKS.UI;

namespace UGBANKS.Core
{
    public class Dashboard
    {
        public static List<Transactions> transactions = new List<Transactions>();
        public static void dashboard(List<Customer> customers, string accountNumber)
        {
            Customer AccountOnwer = customers.FirstOrDefault(a => a.AccountNumber == accountNumber);

            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("      Welcome to UGBANKS " + AccountOnwer.FirstName.ToUpper() + " " + AccountOnwer.LastName.ToUpper());
            Console.WriteLine("      Your Account Number is " +  AccountOnwer.AccountNumber);
            Console.WriteLine("**************************************************");
            int option = 0;
            do
            {
                Thread.Sleep(700);
                Selections.options();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { Deposit.depositMoney(AccountOnwer, transactions); }
                else if (option == 2) { Withdraw.withdrawMoney(AccountOnwer, transactions); }
                else if (option == 3) { CheckBalance.balance(AccountOnwer); }
                else if (option == 4) { Transfer.UserTransfer(AccountOnwer, customers, transactions); }
                else if (option == 5) { PrintTransaction.print(AccountOnwer, transactions);}
                else if (option == 6) { NewAccount.register(customers, AccountOnwer); }
                else if (option == 7) { PrintAccounts.print(customers, AccountOnwer);}
                else if (option == 8) { break; }
                else {
                    Console.WriteLine("Enter a valid option");
                    option = 0;
                   }

            } while (option != 8);

            HomePage.main();

        }
    }
}
