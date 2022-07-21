using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Helpers
{
    public class GenerateAccountNumber
    {
        public static string accountNumber()
        {
            return DateTime.UtcNow.Ticks.ToString().Substring(8);
        }
    }
}
