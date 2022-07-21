using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class EmailValidation
    {
        public static string email()
        {
            string email;
            do
            {
                email = Console.ReadLine();
                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("ERROR: Email address must not be empty");
                    Console.WriteLine("Enter email");
                }
                else if (!Regex.IsMatch(email, @"^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
                    Console.WriteLine("ERROR: Enter a valid email address");
                else
                    break;
            }
            while (true);
            return email;
        }
    }
}
