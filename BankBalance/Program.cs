using System;

namespace BankBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings mySavingAccount = new Savings(100);
            mySavingAccount.AddMonthlyInterest(0.0045m);
            mySavingAccount.ShowBalance();

            Checking myCheckingAccount = new Checking(100);
            myCheckingAccount.DeductServiceCharge();
            myCheckingAccount.ShowBalance();

            JointAccount ourJointAccount = new JointAccount("Tasnuva Haque", "Nobinur Rahman", 150);
            ourJointAccount.showAccountHolderName();
            ourJointAccount.AddMonthlyInterest(0.0049m);
            ourJointAccount.ShowBalance();
        }
    }
}
