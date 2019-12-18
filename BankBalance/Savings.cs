using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Savings : Account
    {
        protected decimal balance { get; set; }
        public Savings() { }
        public Savings( decimal balance)
        {
            Console.WriteLine("Inside the Savings child class constructor");
            BankBalance = balance;
        }
        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }

    }
}
