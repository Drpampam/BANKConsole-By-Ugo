using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class TextValidation
    {
        public static string name()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {

                    Console.WriteLine("ERROR: First name can not be empty");
                    Console.WriteLine("Enter a valid name: ");
                }

                else if (input.Length < 2)
                {

                    Console.WriteLine("Invalid Name: Enter a valid name");
                    Console.WriteLine("Enter a valid name: ");
                }

                else if (char.IsLower(input[0]))
                {

                    Console.WriteLine("ERROR: First letter must start with uppercase E.g \"John\" ");
                    Console.WriteLine("Enter a valid name: ");
                }

                else if (char.IsDigit(input[0]))
                {

                    Console.WriteLine("ERROR: First letter must start with uppercase and not number E.g \"John\" ");
                    Console.WriteLine("Enter a valid name: ");
                }

                else if (!char.IsLetterOrDigit(input[0]))
                {

                    Console.WriteLine("ERROR: First letter must start with uppercase and not special E.g \"John\" ");
                    Console.WriteLine("Enter a valid name: ");
                }
                else if (input.Length >= 3)
                    break;
            }
            while (true);
            return input;
        }
    }
}
