using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Core;
using UGBANKS.Helpers;
using UGBANKS.Models;
using UGBANKS.UI;
using UGBANKS.Utilities;

namespace UGBANKS.Auth
{
    public class Authentication
    {
        public static List<Customer> customers = new List<Customer>();
        public static void register()
        {
            Console.Clear();

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("* Bank with us, we offer high quality services 24/7 customer care *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
            Console.WriteLine("Enter Your First Name: ");
            string firstName = TextValidation.name();
            Console.WriteLine("Enter Your Last Name");
            string lastName = TextValidation.name();    
            Console.WriteLine("Enter Your Email Address");
            string email = EmailValidation.email();
            string accountNumber = GenerateAccountNumber.accountNumber();
            string verifyPass = "";
            Console.WriteLine("Enter Password");
            //string pass = PasswordValidation.password();
            string pass = PV.password();
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("Confirm Password");
                string confirmPass = PV.password();
                if (pass != confirmPass)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: Password not match");
                }
                else
                {
                    verifyPass = confirmPass;
                    break;
                }

            } while (true);
          
            customers.Add(new Customer(
                  firstName,
                  lastName,
                  email,
                  verifyPass,
                  accountNumber,
                  0,
                  AccountOption.options()
                ));

            Delay.delay();
          
            Dashboard.dashboard(customers, accountNumber);
          
        }
        //LOGIN SESSION
        public static void login()
        {
            Console.Clear();
            bool flag = true;
            Customer AccHolder;

            Console.WriteLine("********************************");
            Console.WriteLine("*     Login to Dashboard       *");
            Console.WriteLine("********************************");
            do
            {               
                Console.WriteLine();
                Console.WriteLine("Enter your Account number");
                string accountNumber = AccountNumberValidation.validAccountNumber();
                //string password = PasswordValidation.password();
                Console.WriteLine("Enter password");
                string password = PV.password();
                AccHolder = customers.FirstOrDefault(a => a.AccountNumber == accountNumber);
                if (AccHolder != null)
                {
                    if (AccHolder.Password == password)
                    {
                     
                        Delay.delay();
                        Dashboard.dashboard(customers, accountNumber);
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR: Invalid cerenditials");

                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: This user does not have account");
                    Console.WriteLine("Press \"Y\" to create an account or enter any key to re-try");
                    string opt = Console.ReadLine();
                    if (opt != null && opt == "Y" || opt == "y")
                    {
                        break;
                    }
                }

            }
            while (flag);

        }
        }
}
