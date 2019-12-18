using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Account
    {
        protected decimal BankBalance { get; set; }

        protected virtual decimal StartBalance { get; set; }
        protected Account()
        {
            Console.WriteLine("Inside the Account base class constructor");
            StartBalance = 0;
        }

        public virtual void ShowStartBalance()
        {
            Console.WriteLine("Thank you for opening your account.");

        }

        public void ShowBalance()
        {
            Console.WriteLine($"The balance is: {BankBalance.ToString("C")}");
        }

    }
}
