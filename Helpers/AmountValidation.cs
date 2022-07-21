using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class AmountValidation
    {
        public static decimal amount()
        {
           decimal amount = 0;
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {

                    Console.WriteLine("ERROR: Amount can not be empty");
                    Console.WriteLine("Enter a valid amount: ");
                }
                else
                {
                    if (decimal.TryParse(input, out amount))
                    {
                        if(amount <= 0)
                        {
                            Console.WriteLine("ERROR: Invalid amount");
                        }
                        else
                        {
                            break;
                        }
                         
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Enter a valid amount");
                    }
                }

            }
            while (true);
            return amount;
        }
    }
}
