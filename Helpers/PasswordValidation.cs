using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class PasswordValidation
    {
        public static string password()
        {
            string password;
            var hasNumber = new Regex(@"[0-9]+");
            var hasChars = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            do
            {

                password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("ERROR: Password must not be empty");
                    Console.WriteLine("Enter password");
                }                                 
                else if (password.Length >= 6)
                {
                    if (!hasNumber.IsMatch(password))
                    {
                        Console.WriteLine("ERROR: Password must have a least one number");
                        Console.WriteLine("Enter password");
                    }               
                        
                    else if (!hasChars.IsMatch(password))
                    {
                        Console.WriteLine("ERROR: Password must have a least one letter");
                        Console.WriteLine("Enter password");
                    }
                       
                    else if (!hasSymbols.IsMatch(password))
                    {
                        Console.WriteLine("ERROR: Password must have a least one special E.g \"@#!%^&*\"");
                        Console.WriteLine("Enter password");
                    }
                        
                    else
                        break;
                }
                else if (password.Length < 6)
                {
                    Console.WriteLine("ERROR: Password must be not be less than 6 characters");
                    Console.WriteLine("Enter password");
                }
                    
            }
            while (true);
            return password;
        }
    }
}
