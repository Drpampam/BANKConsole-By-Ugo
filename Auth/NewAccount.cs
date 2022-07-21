using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Core;
using UGBANKS.Helpers;
using UGBANKS.Models;
using UGBANKS.Utilities;

namespace UGBANKS.Auth
{
    public class NewAccount
    {
        public static void register(List<Customer> customers, Customer AccoutOnwer)
        {
            Console.Clear();
            Console.WriteLine("*****************************************************************************************");           
            Console.WriteLine("NOTE: THIS ACCOUNT WILL BE" +
               " LINKED WITH THE OWNER OF THIS ACCOUNT NUMBER: "
               + AccoutOnwer.AccountNumber);
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Choose option");
            Console.WriteLine("1. Create new Account ");
            Console.WriteLine("2. Enter any key to go back");
            string opt = Console.ReadLine();
            string verifyPass;

            do
            {
                if (opt == "1")
                {

                    Console.WriteLine("Enter Your First Name: ");
                    string firstName = TextValidation.name();
                    Console.WriteLine("Enter Your Last Name");
                    string lastName = TextValidation.name();
                    Console.WriteLine("Enter Password");
                    string password = PV.password();
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Confirm Password");
                        string confirmPass = PV.password();
                        if (password != confirmPass)
                        {
                            Console.WriteLine("ERROR: Password not match");
                        }
                        else
                        {
                            verifyPass = confirmPass;
                            break;
                        }

                    } while (true);
                    string accountNumber = GenerateAccountNumber.accountNumber();

                    customers.Add(new Customer(
                          firstName,
                          lastName,
                          AccoutOnwer.Email,
                          verifyPass,
                          accountNumber,
                          0,
                          AccountOption.options()
                        ));

                    Delay.delay();
                    Dashboard.dashboard(customers, accountNumber);
                }
                else
                {
                    break;
                }

            } while (true);


        }
    }
}
