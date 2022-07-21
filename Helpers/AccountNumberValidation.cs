using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class AccountNumberValidation
    {
        public static string validAccountNumber()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {

                    Console.WriteLine("ERROR: Account number can not empty");
                    Console.WriteLine("Enter a valid account number: ");
                }
                else if (input.Length < 10)
                {
                    Console.WriteLine("ERROR: Invalid Account Number: Enter a 10 digit account number");
                    Console.WriteLine("Enter a valid account number: ");
                }
                else if (input.Length == 10)
                {
                    if (input.All(char.IsDigit))
                        break;
                    else
                    {
                        Console.WriteLine("ERROR: Invalid Account Number: Enter a 10 digit account number");
                        Console.WriteLine("Enter a valid account number");
                    }
                }
                else if (input.Length > 10)
                {

                    Console.WriteLine("ERROR: Invalid Account Number: Enter a 10 digit account number");
                    Console.WriteLine("Enter a valid account number");
                }
            }
            while (true);
            return input;
        }
    }
}
