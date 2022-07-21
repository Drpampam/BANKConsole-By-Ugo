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
    public class Withdraw
    {
        static DateTime todaysDate = DateTime.Now;
        static string dateString = String.Format("{0:dd/MM/yyyy}", todaysDate);
        public static void withdrawMoney(Customer Details, List<Transactions> tranc)
        {
            Header.header(Details);

            // CHECK IF THE USER HAS ENOUGH MONEY
            decimal withdraw = 0;
            do
            {
                Console.WriteLine("Withdraw: Enter Amount to withdraw: ");
                withdraw = AmountValidation.amount();
                if (Details.Balance <= withdraw)
                {
                    if (Details.AccountType == "Savings" && Details.Balance - withdraw < 1000)
                    {
                        Console.WriteLine("Transaction Error: Insufficient balance :(");
                        Console.WriteLine("Press \"Y\" to see other options or enter any key to continue");
                        string opt = Console.ReadLine();
                        if (opt != null && opt == "Y" || opt == "y")
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Transaction Error: Insufficient balance :(");
                        Console.WriteLine("Press \"Y\" to see other options or enter any key to continue");
                        string opt = Console.ReadLine();
                        if (opt != null && opt == "Y" || opt == "y")
                        {
                            break;
                        }
                    }

                }
                else
                {
                    Details.Balance = Details.Balance - withdraw;
                    Delay.delay();
                    Console.WriteLine("Transaction Successful: Your transaction is completed");
                    break;
                }
            } while (true);
     
            tranc.Add(new Transactions(
                dateString,
                Details.AccountNumber,
                "withdraw",
                withdraw,
                Details.Balance
                ));
        }
    }
}
