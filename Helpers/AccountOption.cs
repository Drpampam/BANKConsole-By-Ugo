using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
     public class AccountOption
    {
        public static string options()
        {
           string option;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Select account type");
                Console.WriteLine("1. Savings");
                Console.WriteLine("2. Current");
                option = Console.ReadLine();
                if (string.IsNullOrEmpty(option))
                {
                    Console.WriteLine("ERROR: Choose an account type to contiue");
                }
                else if (option == "1")
                {
                    option = "Savings";
                    break;
                }
                else if (option == "2")
                {
                    option = "Current";
                    break;
                }
                else
                    Console.WriteLine("ERROR: Enter a valid option");
            }
            while (true);
            return option;
        }
    }
}
