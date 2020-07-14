using System;
using System.Collections.Generic;
using System.Text;

namespace UPeDowncasting.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        //Utilizar o protected faz com que a variavel possa ser alterada em subclasses (que herdam esta) mas não nas outras:
        public double Balance { get;  set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}