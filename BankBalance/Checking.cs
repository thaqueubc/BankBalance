using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Checking : Account
    {
        public Checking(decimal balance)
        {
            Console.WriteLine("Inside the Checking child class constructor");
            BankBalance = balance;
        }
        public void DeductServiceCharge()
        {
            BankBalance -= 1.5m;
        }

    }
}
