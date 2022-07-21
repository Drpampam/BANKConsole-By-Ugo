using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGBANKS.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }

        public Customer(string firstName, string lastName, string email, string password, string accountNumber, decimal balance, string accountType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
        }
    }
}
