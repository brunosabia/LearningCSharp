using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverride.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
