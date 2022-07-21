using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Utilities
{
    public class Delay
    {
        public static void delay()
        {
            Console.WriteLine();
            Console.Write("Processing");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(150);
                Console.Write("_ ");
            }
            Console.WriteLine();
        }
    }
}
