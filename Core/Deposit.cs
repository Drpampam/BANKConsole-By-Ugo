using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Helpers;
using UGBANKS.Models;
using UGBANKS.Utilities;

namespace UGBANKS.Core
{
    public class Deposit
    {
        static DateTime todaysDate = DateTime.Now;
        static string dateString = String.Format("{0:dd/MM/yyyy}", todaysDate);
        public static void depositMoney(Customer Details, List<Transactions> tranc)
        {

            Header.header(Details);
            decimal deposit = 0;
            do
            {
                Console.WriteLine("Deposit: How much would you like to deposit");
                deposit = AmountValidation.amount();
                if (deposit <= 0)
                {
                    Console.WriteLine("Transaction error: Enter amount greater than 0");
                    Console.WriteLine("Press \"Y\" to see other options or enter any key to continue");
                    string opt = Console.ReadLine();
                    if (opt != null && opt == "Y" || opt == "y")
                    {
                        break;
                    }
                }
                else
                {
                    Details.Balance = Details.Balance + deposit;
                    Delay.delay();
                    Console.WriteLine("Transaction successful: Your transaction is completed");
                    break;
                }
            } while (true);

            Console.WriteLine("Your new balance is: " + Details.Balance);
            tranc.Add(new Transactions(
                 dateString,
                Details.AccountNumber,
                "Deposit",
                deposit,
                Details.Balance
                ));

        }
    }
}
