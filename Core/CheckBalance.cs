using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Models;
using UGBANKS.Utilities;

namespace UGBANKS.Core
{
    public class CheckBalance
    {
        public static void balance(Customer Details)
        {
            Header.header(Details);
            Console.WriteLine("Your account balance is: " + Details.Balance);
            
        }
    }
}
