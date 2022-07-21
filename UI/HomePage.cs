using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGBANKS.Auth;

namespace UGBANKS.UI
{
    public class HomePage
    {
        public static void main()
        {
            string opt = "0";
            bool flag = true;
            do
            {
                Console.Clear();
                Console.WriteLine("*****************************************************");
                Console.WriteLine("* Welcome to UGBANK, Best place to save your money  *");
                Console.WriteLine("* Choose your option                                *");
                Console.WriteLine("* 1. Login                                          *");
                Console.WriteLine("* 2. Create Account                                 *");
                Console.WriteLine("* 3. Exit                                           *");
                Console.WriteLine("*****************************************************");
                opt = Console.ReadLine();

                if (opt == "1")
                    Authentication.login();
                else if (opt == "2")
                    Authentication.register();
                else if (opt == "3")
                    break;
                else
                {

                    Console.WriteLine("Choose a valid option");
                    opt = "0";
                    Thread.Sleep(800);
                }

            } while (true);
        }
    }
}
