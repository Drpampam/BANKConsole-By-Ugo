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
    public class Transfer
    {
        public static DateTime dateTime = DateTime.Now;
        public static void UserTransfer(Customer sender, List<Customer> users, List<Transactions> tranc)
        {
            Customer Receiver;
            Header.header(sender);

            decimal amount = 0;
            do
            {
                Console.WriteLine("Enter receivers account number");
                string ReceiverAcc = AccountNumberValidation.validAccountNumber();
                Console.WriteLine("Enter amount");
                amount = AmountValidation.amount();
                Receiver = users.FirstOrDefault(a => a.AccountNumber == ReceiverAcc);

                if (Receiver != null)
                { 
                    if (amount > 0)
                    {
                        if (sender.Balance >= amount && sender.Balance > 1000)
                        {
                            sender.Balance -= amount;
                            Receiver.Balance += amount;

                            Delay.delay();
                            Console.WriteLine("Transaction successful: Transfer successful");

                            //Add transaction history for the sender
                            tranc.Add(new Transactions(
                            dateTime.ToString("dd/MM/yyyy"),
                            sender.AccountNumber,
                            String.Format("Transfer to {0}", Receiver.FirstName),
                            amount,
                            sender.Balance
                              ));

                            // Add transaction history for the receiver
                            tranc.Add(new Transactions(
                            dateTime.ToString("dd/MM/yyyy"),
                            Receiver.AccountNumber,
                            String.Format("Credited by {0}", sender.FirstName),
                            amount,
                            Receiver.Balance
                              ));

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Transaction Error: Insufficient funds for this transaction");
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
                        Console.WriteLine("Transaction Error: Amount too low for transfer");
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
                    Console.WriteLine("ERROR: Account Number not found");
                    Console.WriteLine("Press \"Y\" to see other options or enter any key to continue");
                    string opt = Console.ReadLine();
                    if (opt != null && opt == "Y" || opt == "y")
                    {
                        break;
                    }
                }

            } while (true);

        }


        }
}
