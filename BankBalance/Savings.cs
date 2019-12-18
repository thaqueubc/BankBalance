using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Savings : Account
    {
        public Savings(decimal balance)
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
