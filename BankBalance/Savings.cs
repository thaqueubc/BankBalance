using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Savings : Account
    {
        protected decimal balance { get; set; }

        protected override decimal StartBalance { set { base.StartBalance = value + 50; } }
        public Savings() { }
        public Savings( decimal balance)
        {
            Console.WriteLine("Inside the Savings child class constructor");
            BankBalance = balance + StartBalance ;
           
        }

        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }

        public override void ShowStartBalance()
        {
            Console.WriteLine($"Your account was credited: {StartBalance.ToString("C")}");
            base.ShowStartBalance(); //optional call to the base method
        }


    }
}
