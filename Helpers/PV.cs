using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security;
using System.Net;

namespace UGBANKS.Helpers
{
    public class PV
    {
        public static string password()
        {
            string password;
            
            var hasNumber = new Regex(@"[0-9]+");
            var hasChars = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            do
            {
                SecureString pass = new SecureString();
                ConsoleKeyInfo keyInfo;

                do
                {

                    keyInfo = Console.ReadKey(true);
                    if (!char.IsControl(keyInfo.KeyChar))
                    {                        
                        pass.AppendChar(keyInfo.KeyChar);
                        Console.Write("*");
                    }
                    else if (keyInfo.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass.RemoveAt(pass.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                while (keyInfo.Key != ConsoleKey.Enter);
                {

                    string Password = new NetworkCredential(string.Empty, pass).Password;
                    password = Password;

                }


                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine();
                    Console.WriteLine(" ERROR: Password must not be empty");
                    Console.WriteLine("Enter password");
                }
                else if (password.Length >= 6)
                {
                    if (!hasNumber.IsMatch(password))
                    {
                        Console.WriteLine();
                        Console.WriteLine(" ERROR: Password must have a least one number");
                        Console.WriteLine("Enter password");
                    }

                    else if (!hasChars.IsMatch(password))
                    {
                        Console.WriteLine();
                        Console.WriteLine(" ERROR: Password must have a least one letter");
                        Console.WriteLine("Enter password");
                    }

                    else if (!hasSymbols.IsMatch(password))
                    {
                        Console.WriteLine();
                        Console.WriteLine(" ERROR: Password must have a least one special E.g \"@#!%^&*\"");
                        Console.WriteLine("Enter password");
                    }

                    else
                        break;
                }
                else if (password.Length < 6)
                {
                    Console.WriteLine();
                    Console.WriteLine(" ERROR: Password must be not be less than 6 characters");
                    Console.WriteLine("Enter password");
                }

            }
            while (true);
            return password;
        }
    }
}
