using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverride.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        //Utilizar o protected faz com que a variavel possa ser alterada em subclasses (que herdam esta) mas não nas outras:
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //Adicionar o virtual faz com que o metodo possa ser sobrescrito na subclasse.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}