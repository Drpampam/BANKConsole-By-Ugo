using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class Selections
    {
        public static void options()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Select option to perform a transaction");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1. Desposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Print transactions");
            Console.WriteLine("6. Create new Account");
            Console.WriteLine("7. Print account details");
            Console.WriteLine("8. Logout");
           
        }
    }
}
