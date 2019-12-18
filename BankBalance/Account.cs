using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Account
    {
        protected decimal BankBalance { get; set; }
        protected Account()
        {
            Console.WriteLine("Inside the Account base class constructor");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"The balance is: {BankBalance.ToString("C")}");
        }

    }
}
